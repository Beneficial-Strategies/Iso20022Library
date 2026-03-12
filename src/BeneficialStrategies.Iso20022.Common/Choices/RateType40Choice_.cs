// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType40Choice.Code))]
    [KnownType(typeof(RateType40Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType40Choice.Code),nameof(RateType40Choice.Code))]
    [JsonDerivedType(typeof(RateType40Choice.Proprietary),nameof(RateType40Choice.Proprietary))]
    [IsoId("_MjGzn0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 40 Choice")]
    public abstract partial record RateType40Choice_
    {
    }
}
