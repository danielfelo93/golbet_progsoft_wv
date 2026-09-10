using GolBet.Entities;

using GolBet.Entities.Enums;
using GolBet.Repositories.Data;
using GolBet.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace GolBet.Repositories.Interfaces;
public interface IMatchRepository : IGenericRepository<Match>
{
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);
} 
