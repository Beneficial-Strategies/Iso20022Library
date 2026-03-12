// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType4Choice.Code))]
    [KnownType(typeof(ChargeType4Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType4Choice.Code),nameof(ChargeType4Choice.Code))]
    [JsonDerivedType(typeof(ChargeType4Choice.Proprietary),nameof(ChargeType4Choice.Proprietary))]
    [IsoId("_gfFvsQatEeS3lpTattq7hg")]
    [DisplayName("Charge Type 4 Choice")]
    public abstract partial record ChargeType4Choice_
    {
    }
}
