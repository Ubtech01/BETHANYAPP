﻿using BETHANYAPP.Models;

namespace BETHANYAPP.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public string? CurrentCategory { get; }

        public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
        {
            Pies = Pies;
            CurrentCategory = currentCategory;

        }
    }
}
