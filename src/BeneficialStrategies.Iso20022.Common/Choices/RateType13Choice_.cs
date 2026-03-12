// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType13Choice.Code))]
    [KnownType(typeof(RateType13Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType13Choice.Code),nameof(RateType13Choice.Code))]
    [JsonDerivedType(typeof(RateType13Choice.Proprietary),nameof(RateType13Choice.Proprietary))]
    [IsoId("_Q2uKotp-Ed-ak6NoX_4Aeg_-94553220")]
    [DisplayName("Rate Type 13 Choice")]
    public abstract partial record RateType13Choice_
    {
    }
}
