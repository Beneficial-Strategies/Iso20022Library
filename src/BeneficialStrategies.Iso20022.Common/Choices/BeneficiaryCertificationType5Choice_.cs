// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType5Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType5Choice.Code),
        nameof(BeneficiaryCertificationType5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType5Choice.Proprietary),
        nameof(BeneficiaryCertificationType5Choice.Proprietary)
    )]
    [IsoId("_NqankfmgEeCXPrLWfSEUvQ")]
    [DisplayName("Beneficiary Certification Type 5 Choice")]
    public abstract record BeneficiaryCertificationType5Choice_ { }
}
