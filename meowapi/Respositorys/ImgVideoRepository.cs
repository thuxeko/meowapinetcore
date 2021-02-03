using meowapi.Base;
using meowapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meowapi.Respositorys
{
    public class ImgVideoRepository : MongoRepository<db_img_video>, IImgVideoRepository
    {
        public ImgVideoRepository(IMongoContext context) : base(context)
        {
        }
    }
}
