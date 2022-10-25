using log4net;
using RazorViewV1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;
using System.Web.Services.Description;

namespace RazorViewV1.Utility
{
    public class BinaryIntellectVirtualPathProvider : VirtualPathProvider
    {
        BloggingContext db;
        public BinaryIntellectVirtualPathProvider()
        {
            db = new BloggingContext();
        }
        public override bool FileExists(string virtualPath)
        {
            var view = GetViewFromDatabase(virtualPath);
            if (!virtualPath.Contains("/Views") || view == null)
            {
                return base.FileExists(virtualPath);
            }
            else
            {
                return true;
            }
        }

        public override VirtualFile GetFile(string virtualPath)
        {
            var view = GetViewFromDatabase(virtualPath);

            if (view == null)
            {
                return base.GetFile(virtualPath);
            }
            else
            {
                byte[] content = ASCIIEncoding.ASCII.
                                 GetBytes(view.ViewData);
                return new BinaryIntellectVirtualFile
                              (virtualPath, content);
            }
        }

        public override CacheDependency GetCacheDependency
         (string virtualPath, IEnumerable virtualPathDependencies,
          DateTime utcStart)
        {

            //var view = GetViewFromDatabase(virtualPath);

            //if (view != null)
            //{
            //    return null;
            //}

            return Previous.GetCacheDependency(virtualPath,
               virtualPathDependencies, utcStart);
        }

        public override String GetFileHash(String virtualPath, IEnumerable virtualPathDependencies)
        {
            return Guid.NewGuid().ToString().ToUpper();

        }

        private RAZOR_PAGES GetViewFromDatabase(string virtualPath)
        {
            virtualPath = virtualPath.Replace("~", "");
            var query = from razor_pages in db.Blogs select razor_pages;

            var view = from v in query
                       where v.ViewName.Replace("/", "").ToLower().Contains(virtualPath.Replace("/", "").ToLower())
                       select v;
            return view.SingleOrDefault();
        }
    }

    public class BinaryIntellectVirtualFile : VirtualFile
    {
        private byte[] viewContent;

        public BinaryIntellectVirtualFile(string virtualPath,
           byte[] viewContent) : base(virtualPath)
        {
            this.viewContent = viewContent;
        }

        public override Stream Open()
        {
            return new MemoryStream(viewContent);
        }
    }

    public partial class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("name=RazorView1")
        {
        }

        public virtual DbSet<RAZOR_PAGES> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}