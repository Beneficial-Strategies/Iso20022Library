// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType6Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType6Choice.Code),
        nameof(BeneficiaryCertificationType6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType6Choice.Proprietary),
        nameof(BeneficiaryCertificationType6Choice.Proprietary)
    )]
    [IsoId("_UozIoQE4EeG0G9kfgQ0HLA")]
    [DisplayName("Beneficiary Certification Type 6 Choice")]
    public abstract record BeneficiaryCertificationType6Choice_ { }
}
