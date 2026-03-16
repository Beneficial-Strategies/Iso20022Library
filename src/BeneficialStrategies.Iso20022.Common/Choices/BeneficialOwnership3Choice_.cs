// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the beneficial ownership.
    /// </summary>
    [KnownType(typeof(BeneficialOwnership3Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficialOwnership3Choice.Indicator),
        nameof(BeneficialOwnership3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(BeneficialOwnership3Choice.Proprietary),
        nameof(BeneficialOwnership3Choice.Proprietary)
    )]
    [IsoId("_AbDZwdokEeC60axPepSq7g_1929914426")]
    [DisplayName("Beneficial Ownership 3 Choice")]
    public abstract record BeneficialOwnership3Choice_ { }
}
