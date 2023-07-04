using BookStoreCoreMVC.Models.ViewModels.Category;
using System.ComponentModel.DataAnnotations;

namespace BookStoreCoreMVC.Models.ViewModels.Book;

public class CreateBooksFormGetViewModel
{

    public CreateBooksFormGetViewModel()
    {

    }
    public CreateBooksFormGetViewModel(IEnumerable<TreeViewCategoryViewModel> viewCategories)
    {
        Categories = viewCategories;
    }
    public IEnumerable<TreeViewCategoryViewModel>? Categories { get; set; }


    [Display(Name = "عنوان")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public string Title { get; set; }

    [Display(Name = "خلاصه")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public string Summary { get; set; }

    [Display(Name = "قیمت")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    [Range(0, int.MaxValue, ErrorMessage = "{0} باید مقداری مثبت باشد")]
    public int Price { get; set; }

    [Display(Name = "موجودی")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    [Range(0, int.MaxValue, ErrorMessage = "{0} باید مقداری مثبت باشد")]
    public int Stock { get; set; }

    //public string File {get; set; }

    [Display(Name = "تعداد صفحات")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    [Range(0, int.MaxValue, ErrorMessage = "{0} باید مقداری مثبت باشد")]
    public int NumOfPage { get; set; }

    [Display(Name = "وزن")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    [Range(0, short.MaxValue, ErrorMessage = "{0} باید مقداری مثبت باشد")]
    public short Weight { get; set; }

    [Display(Name = "شابک")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public string ISBN { get; set; }

    [Display(Name = "این کتاب روی سایت منتشر شود.")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public bool IsPublish { get; set; }

    [Display(Name = "سال انتشار")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    [Range(1950, 2022, ErrorMessage = "{0} باید مقداری بین 1950 - 2022 باشد")]
    public int PublishYear { get; set; }

    [Display(Name = "زبان")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public int LanguageID { get; set; }

    [Display(Name = "ناشر")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public int PublisherID { get; set; }

    //public byte[] Image { get; set; }

    [Display(Name = "نویسندگان")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public int[] AuthorsID { get; set; }

    [Display(Name = "مترجمان")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public int[] TranslatorsID { get; set; }

    [Display(Name = "دسته بندی ها")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است.")]
    public int[] CategoryID { get; set; }

    public class TranslatorList
    {
        public int TranslatorId { get; set; }
        public string NameFamily { get; set; }
    }

    public class AuthorList
    {
        public int AuthorId { get; set; }
        public string NameFamily { get; set; }
    }

}



