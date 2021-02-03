using meowapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meowapi.Interfaces
{
    public interface IImgVideoService
    {
        Task<db_img_video> AddIVAsync(db_img_video obj);
        Task<db_img_video> UpdateIVAsync(string id, db_img_video obj);
        Task<bool> RemoveIVAsync(string id);
        Task<db_img_video> GetByIdAsync(string id);
        Task<IEnumerable<db_img_video>> GetAll();
    }
}
