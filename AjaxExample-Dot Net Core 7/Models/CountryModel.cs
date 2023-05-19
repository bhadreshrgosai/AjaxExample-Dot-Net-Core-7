namespace AjaxExample_Dot_Net_Core_7.Models
{
    public class CountryModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public bool IsActive { get; set; } = false;
    }
}
