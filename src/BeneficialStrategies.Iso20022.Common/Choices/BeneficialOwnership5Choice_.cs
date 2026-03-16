// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the beneficial ownership.
    /// </summary>
    [KnownType(typeof(BeneficialOwnership5Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficialOwnership5Choice.Indicator),
        nameof(BeneficialOwnership5Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(BeneficialOwnership5Choice.Proprietary),
        nameof(BeneficialOwnership5Choice.Proprietary)
    )]
    [IsoId("_5m6A45NLEeWGlc8L7oPDIg")]
    [DisplayName("Beneficial Ownership 5 Choice")]
    public abstract record BeneficialOwnership5Choice_ { }
}
