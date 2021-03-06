﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NFineCore.EntityFramework.Models.WeixinManage
{
    public class WxNewsItem
    {
        public long Id { get; set; }
        public int Index { get; set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public string Digest { get; set; }
        public string Content { get; set; }
        public string ContentSourceUrl { get; set; }
        public int ShowCoverPic { get; set; }
        public int NeedOpenComment { get; set; }
        public int OnlyFansCanComment { get; set; }
        public bool? DeletedMark { get; set; }
        public DateTime? CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }
        public long? NewsId { get; set; }
        public virtual WxNews WxNews { get; set; }
        public long? ThumbId { get; set; }
        public virtual WxImage Thumb { get; set; }
    }
}
