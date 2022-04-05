namespace Axon.me.ViewModels

{
    public class CategoryViewModel
    {
        public int Count { get; set; }
        public string Description { get; set; }
        public int Parent { get; set; }

        public static implicit operator CategoryViewModel(WordPressPCL.Models.Category model)
        {
            return new CategoryViewModel()
            {
                Count = model.Count,
                Description = model.Description,
                Parent = model.Parent
            };
        }
    }
}
