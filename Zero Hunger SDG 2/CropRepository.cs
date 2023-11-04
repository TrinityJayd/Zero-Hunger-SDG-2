using Zero_Hunger_SDG_2.Models;

namespace Zero_Hunger_SDG_2
{
    public class CropRepository
    {
        private readonly ZeroHungerContext _context;

        public CropRepository(ZeroHungerContext context)
        {
            _context = context;
        }


        public IEnumerable<Crop> GetAll()
        {
            return _context.Crops.ToList();
        }

        public Crop GetCropById(int id)
        {
            return _context.Crops.Find(id);
        }

        

        public Crop Add(Crop newCrop)
        {
            int nextId = _context.Crops.Max(c => c.CropId) + 1;
            newCrop.CropId = nextId;
            _context.Crops.Add(newCrop);
            _context.SaveChanges();
            return newCrop;
        }

        public void Update(Crop updatedCrop)
        {
            _context.Crops.Update(updatedCrop);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var existingCrop = _context.Crops.Find(id);
            if (existingCrop != null)
            {
                _context.Crops.Remove(existingCrop);
                _context.SaveChanges();
            }
        }

        public decimal TotalCropIncome()
        {
            return _context.Crops.Sum(c => c.CropIncome);
        }

        public decimal TotalCropExpenses()
        {
            return _context.Crops.Sum(c => c.CropExpenses);
        }

        public int TotalCropYield()
        {
            return _context.Crops.Sum(c => c.CropYield);
        }


    }
}
