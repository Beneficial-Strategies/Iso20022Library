// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of balance types to provide transaction details.
    /// </summary>
    [KnownType(typeof(AdjustedBalanceTypeSD2Choice.StockLoan))]
    [KnownType(typeof(AdjustedBalanceTypeSD2Choice.Repo))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD2Choice.StockLoan),nameof(AdjustedBalanceTypeSD2Choice.StockLoan))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD2Choice.Repo),nameof(AdjustedBalanceTypeSD2Choice.Repo))]
    [IsoId("_vSOqAUk9EeK8UrXTVVBVxw")]
    [DisplayName("Adjusted Balance Type SD 2 Choice")]
    public abstract partial record AdjustedBalanceTypeSD2Choice_
    {
    }
}
