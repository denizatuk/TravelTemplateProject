using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
