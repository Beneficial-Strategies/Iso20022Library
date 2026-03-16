// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType9Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType9Choice.Code),
        nameof(BeneficiaryCertificationType9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType9Choice.Proprietary),
        nameof(BeneficiaryCertificationType9Choice.Proprietary)
    )]
    [IsoId("_T0S-4fiyEeSjz7lzcp5lWQ")]
    [DisplayName("Beneficiary Certification Type 9 Choice")]
    public abstract record BeneficiaryCertificationType9Choice_ { }
}
