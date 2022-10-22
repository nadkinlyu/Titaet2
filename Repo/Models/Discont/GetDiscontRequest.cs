using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Repo.Models.Discont{

public class GetDiscontRequest : IPaginationRequest
{
	public long? Id { get; set; } = null;

	public Page Page { get; set; } = new Page();
}
}