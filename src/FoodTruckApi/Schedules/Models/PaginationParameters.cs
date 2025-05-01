namespace FoodTruckNationApi.Schedules
{
    /// <summary>
    /// Represents the parameters used for paginating a collection of items.
    /// </summary>
    public class PaginationParameters
    {
        /// <summary>
        /// Gets or sets the current page number.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the number of items per page.
        /// </summary>
        public int PageSize { get; set; }
    }
}
