using System.Threading.Tasks;
using CaprarSalajan_AnaCezara_Lab5.Models;

namespace CaprarSalajan_AnaCezara_Lab5.Services
{
    public interface IRiskPredictionService
    {
        Task<string> PredictRiskAsync(RiskInput input);
    }
}
