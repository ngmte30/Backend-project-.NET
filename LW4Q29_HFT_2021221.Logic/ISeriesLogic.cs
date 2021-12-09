using System;
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
        IQueryable<Series> GetAll();

        void Create(Series sr);
        void Delete(int sr);
        void Read(int id);
        void Update(Series sr);
    }
}
