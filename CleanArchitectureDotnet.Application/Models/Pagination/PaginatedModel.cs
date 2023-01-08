﻿namespace CleanArchitectureDotnet.Application.Models.Pagination
{
    public class PaginatedModel<TModel>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public List<TModel> Data { get; set; }

        public PaginatedModel(List<TModel> data,int pageNumber,int pageSize)
        {
            Data = data;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}

