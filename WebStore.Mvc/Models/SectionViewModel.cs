namespace WebStore.Mvc.Models
{
    public class SectionViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int Order { get; set; }

        public SectionViewModel? ParentSection { get; set; }

        public IList<SectionViewModel> ChildSections { get; set; }

        public SectionViewModel() => ChildSections = new List<SectionViewModel>();
    }
}
