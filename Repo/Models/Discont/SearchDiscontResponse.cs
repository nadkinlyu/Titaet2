using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Repo.Models.Discont;

public class SearchDiscontResponse : IPaginationResponse<DiscontShortModel>
{
    public Page Page { get; set; } = new Page();

    public long Count { get; set; }

    public IReadOnlyCollection<DiscontShortModel> Items { get; set; }
}
