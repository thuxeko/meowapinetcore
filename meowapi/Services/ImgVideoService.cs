using meowapi.Interfaces;
using meowapi.Models;
using meowapi.Respositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meowapi.Services
{
    public class ImgVideoService : IImgVideoService
    {
        private IImgVideoRepository _imgVideoRepository;
        public ImgVideoService(IImgVideoRepository imgVideoRepository)
        {
            _imgVideoRepository = imgVideoRepository;
        }

        public async Task<db_img_video> AddIVAsync(db_img_video obj)
        {
            return await _imgVideoRepository.Add(obj);
        }

        public async Task<IEnumerable<db_img_video>> GetAll()
        {
            return await _imgVideoRepository.GetAll();
        }

        public async Task<db_img_video> GetByIdAsync(string id)
        {
            return await _imgVideoRepository.GetById(id);
        }

        public async Task<bool> RemoveIVAsync(string id)
        {
            return await _imgVideoRepository.Remove(id);
        }

        public async Task<db_img_video> UpdateIVAsync(string id, db_img_video obj)
        {
            return await _imgVideoRepository.Update(id, obj);
        }
    }
}
