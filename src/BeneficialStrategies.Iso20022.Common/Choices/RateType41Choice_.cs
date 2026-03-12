// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType41Choice.Code))]
    [KnownType(typeof(RateType41Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType41Choice.Code),nameof(RateType41Choice.Code))]
    [JsonDerivedType(typeof(RateType41Choice.Proprietary),nameof(RateType41Choice.Proprietary))]
    [IsoId("_jWcogUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 41 Choice")]
    public abstract partial record RateType41Choice_
    {
    }
}
