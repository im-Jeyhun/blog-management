using System;
using System.Collections.Generic;

namespace blogManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Blog> Blogs = new List<Blog>()
            {
                new Blog ("1.Dunya savasi" , "Birinci Dünya müharibəsi (28 iyul 1914–11 noyabr 1918)" , BLogStatus.Sended, "Dunyasavasi", "1945" , "Almaniya" , "Rusiya" , "Copu" ),
                new Blog ("2.Dunya savasi" , "İkinci Dünya müharibəsi (1941 - 1945)" ,BLogStatus.Sended, "Dunyasavasi", "1945" , "Almaniya" , "Rusiya" , "Copu" )

            };
        }

        public static string GetInAzebaijan(this BLogStatus bLogStatus, bool iSAdmin )
        {
            if(iSAdmin==true)
            {
                if (bLogStatus == BLogStatus.Sended)
                {
                    return "Admine Gonderildi";
                }
                else if (bLogStatus == BLogStatus.Approved)
                {
                    return "Admin Qebul eledi";
                }
                else if (bLogStatus == BLogStatus.Rejected)
                {
                    return "Admin Imtina etdi";
                }

                throw new Exception("Status not found .");
            }
            else
            {
                if (bLogStatus == BLogStatus.Sended)
                {
                    return "Admin terefinden Gonderildi";
                }
                else if (bLogStatus == BLogStatus.Approved)
                {
                    return "Admin terefinden Qebul edildi";
                }
                else if (bLogStatus == BLogStatus.Rejected)
                {
                    return "Admin terefinden Imtina edildi";
                }

                throw new Exception("Status not found .");
            }

     
        }
    }
    public class Blog
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public BLogStatus Status { get; set; }
        public string[]  HasTags { get; set; }
        
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public Blog(string title, string content, BLogStatus status, params string[] hasTags)
        {
            Title = title;
            Content = content;
            HasTags = hasTags;
            Status = status; 
        }
    }

    public enum BLogStatus
    {
        Sended = 1,
        Approved = 2,
        Rejected = 3,
    }

  
}
