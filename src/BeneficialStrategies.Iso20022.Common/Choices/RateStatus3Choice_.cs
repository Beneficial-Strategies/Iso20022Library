// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate status.
    /// </summary>
    [KnownType(typeof(RateStatus3Choice.Code))]
    [KnownType(typeof(RateStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(RateStatus3Choice.Code),nameof(RateStatus3Choice.Code))]
    [JsonDerivedType(typeof(RateStatus3Choice.Proprietary),nameof(RateStatus3Choice.Proprietary))]
    [IsoId("_U9iCP0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Status 3 Choice")]
    public abstract partial record RateStatus3Choice_
    {
    }
}
