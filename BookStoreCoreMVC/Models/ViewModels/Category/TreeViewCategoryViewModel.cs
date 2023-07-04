namespace BookStoreCoreMVC.Models.ViewModels.Category;

public class TreeViewCategoryViewModel
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<TreeViewCategoryViewModel> SubCategories { get; set; }

    public TreeViewCategoryViewModel()
    {
        SubCategories = new List<TreeViewCategoryViewModel>();
    }
}
