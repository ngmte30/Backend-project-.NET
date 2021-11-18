﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Data;
using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public interface IGraphicCardLogic
    {
        GraphicCards GetGpuById(int id);
        void ChangeGpuTitle(int id, string newTitle);
        IList<GraphicCards> GetAllGpus();
        
    }
}
