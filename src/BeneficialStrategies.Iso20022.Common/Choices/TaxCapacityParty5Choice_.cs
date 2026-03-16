// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tax capacity information.
    /// </summary>
    [KnownType(typeof(TaxCapacityParty5Choice.Code))]
    [KnownType(typeof(TaxCapacityParty5Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxCapacityParty5Choice.Code), nameof(TaxCapacityParty5Choice.Code))]
    [JsonDerivedType(
        typeof(TaxCapacityParty5Choice.Proprietary),
        nameof(TaxCapacityParty5Choice.Proprietary)
    )]
    [IsoId("_5TKlZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Tax Capacity Party 5 Choice")]
    public abstract record TaxCapacityParty5Choice_ { }
}
