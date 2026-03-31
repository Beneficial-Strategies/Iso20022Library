// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat9Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat9Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat9Choice.Amount))]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat9Choice.Rate),
        nameof(SolicitationFeeRateFormat9Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat9Choice.AmountToQuantity),
        nameof(SolicitationFeeRateFormat9Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat9Choice.Amount),
        nameof(SolicitationFeeRateFormat9Choice.Amount)
    )]
    [IsoId("_ckNXm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fee Rate Format 9 Choice")]
    public abstract record SolicitationFeeRateFormat9Choice_ { }
}
