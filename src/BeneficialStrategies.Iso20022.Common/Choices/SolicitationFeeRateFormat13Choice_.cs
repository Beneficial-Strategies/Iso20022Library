// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Solicitation Fee Rate Format13Choice.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat13Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat13Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat13Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat13Choice.Amount),nameof(SolicitationFeeRateFormat13Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat13Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat13Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat13Choice.Rate),nameof(SolicitationFeeRateFormat13Choice.Rate))]
    [IsoId("_kv_dq5t3Ee-wQIOX0djF2w")]
    [DisplayName("Solicitation Fee Rate Format13Choice")]
    public abstract partial record SolicitationFeeRateFormat13Choice_
    {
    }
}
