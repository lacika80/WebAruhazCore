using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Interfaces;
using System.Linq;

namespace DAL.Model.Repository
{
    public class PhotoRepo : Interfaces.IPhotoRepo
    {
        private readonly AruhazContext _ctx;
        public PhotoRepo(AruhazContext ctx)
        {
            _ctx = ctx;
        }
        public void DeletePicture(int pId)
        {
            throw new NotImplementedException();
        }

        public IPhotoDTO GetPictureByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public ICollection<IPhotoDTO> GetPictureByUserId(List<int> userId)
        {
            throw new NotImplementedException();
        }

        public ICollection<IPhotoDTO> GetPictures()
        {
            List<IPhotoDTO> phs = new List<IPhotoDTO>();
            foreach (var item in _ctx.Photos)
            {
                phs.Add(item);
            }
            return phs;
        }

        public ICollection<IPhotoDTO> GetPictures(int prodId)
        {
            throw new NotImplementedException();
            List<IPhotoDTO> phs = new List<IPhotoDTO>();
            foreach (var item in _ctx.Photos.Join(_ctx.Photo2Products, ph => ph.PhotoId, p2p => p2p.PhotoId, (ph, p2p) => new { Photo = ph, Photo2Product = p2p}).Where(x => x.Photo2Product.ProdId == prodId))
            {
                //phs.Add(item);
            }
            return phs;
        }

        public ICollection<IPhotoDTO> GetPictures(List<int> prodId)
        {
            throw new NotImplementedException();
        }

        public void UploadPicture(FileStream picture)
        {
            throw new NotImplementedException();
        }

        public void UploadPicture(FileStream picture, int prodId)
        {
            throw new NotImplementedException();
        }
    }
}
