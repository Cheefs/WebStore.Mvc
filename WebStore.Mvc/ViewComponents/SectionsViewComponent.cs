using WebStore.Mvc.Models;
using WebStore.Mvc.Servises.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Mvc.ViewComponents
{
    public class SectionsViewComponent : ViewComponent
    {
        private IProductData _productData;

        public SectionsViewComponent(IProductData productData) => _productData = productData;

        public IViewComponentResult Invoke()
        {
            var sections = GetAll();
            return View(sections);
        }

        private IEnumerable<SectionViewModel> GetAll()
        {
            var allSections = _productData.GetSections();

            var parentCategories = allSections.Where(p => !p.ParentId.HasValue).ToArray();
            var parentSections = new List<SectionViewModel>();

            foreach (var parentCategory in parentCategories)
            {
                parentSections.Add(new SectionViewModel()
                {
                    Id = parentCategory.Id,
                    Name = parentCategory.Name,
                    Order = parentCategory.Order,
                    ParentSection = null
                });
            }

            foreach (var sectionViewModel in parentSections)
            {
                var childCategories = allSections.Where(c => c.ParentId.Equals(sectionViewModel.Id));
                foreach (var childCategory in childCategories)
                {
                    sectionViewModel.ChildSections.Add(new SectionViewModel()
                    {
                        Id = childCategory.Id,
                        Name = childCategory.Name,
                        Order = childCategory.Order,
                        ParentSection = sectionViewModel
                    });
                }
                sectionViewModel.ChildSections = sectionViewModel.ChildSections.OrderBy(c => c.Order).ToList();
            }

            parentSections = parentSections.OrderBy(c => c.Order).ToList();

            return parentSections;
        }
    }
}
