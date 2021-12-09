﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Logic
{
    public interface ISeriesLogic
    {
        Series GetNvidiaById(int id);
        void ChangeNvidiaTitle(int id, string newTitle);
        IList<Series> GetAll();

        void Create(Series sr);
        void Delete(int id);
        void Read();
        void Update();
    }
}