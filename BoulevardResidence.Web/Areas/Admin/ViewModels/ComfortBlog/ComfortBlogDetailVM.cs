﻿namespace BoulevardResidence.Web.Areas.Admin.ViewModels.ComfortBlog
{
    public class ComfortBlogDetailVM
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public List<ComfortBlogTranslateVM> Translates { get; set; }
    }
}
