using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Repo.Models.Card;

public class GetCardRequest: IPaginationRequest
{
    public long? AuthorId { get; set; } = null;

    public Page Page { get; set; } = new Page();
    
}