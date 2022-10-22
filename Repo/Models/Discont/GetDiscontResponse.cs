﻿using PublishingHouse.Interfaces.Extensions.Pagination;
using System.Collections.Generic;
using Data.Models;

namespace Repo.Models.Discont
{

public class GetDiscontResponse : IPaginationResponse<DiscontShortModel>
{
	public Page Page { get; set; } = new Page();

	public long Count { get; set; }

	public IReadOnlyCollection<DiscontShortModel> Items { get; set; }
}
}