﻿using SevenBooksApplication.App_Code;
using SevenBooksApplication.Models;
using System;

namespace SevenBooksApplication
{
    public partial class BookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // int BookID = 4;
            String ISBN = Request.QueryString["ISBN"];
            Book b = BusinessLogic.SearchBookByISBN(ISBN);
            string isbn = b.ISBN;
            tbAuthor.Text = b.Author;
            tbTitle.Text = b.Title;
            tbPrice.Text = Convert.ToString(b.Price);
            int stock = b.Stock;
            int[] stockArray = new int[stock];
            for (int i = 0; i < stock; i++)
            {
                stockArray[i] = i + 1;
            }
            ddlQty.DataSource = stockArray;
            ddlQty.DataBind();
            Image1.ImageUrl = string.Format("image/{0}.jpg", isbn);


        }
    }
}