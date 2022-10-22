using Data.Models;
using PublishingHouse.Interfaces.Model.Author;
using Repo.Models.Card;
using Repo.Models.Discont;

namespace Repo.Servises;

public interface ICardService
{
    Task<Card> Add(long id, long userid, long discontid);

    Task<SearchCardResponse> SearchGard(CardGetModel model);

    Task<GetCardResponse> GetDiscontAsync(GetCardRequest request);

    Task Update(long id, long userid, long discontid);
    Task DeleteCardAsync(long id);

}