// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Beneficiary Certification Type13Choice.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType13Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType13Choice.Code),
        nameof(BeneficiaryCertificationType13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType13Choice.Proprietary),
        nameof(BeneficiaryCertificationType13Choice.Proprietary)
    )]
    [IsoId("_HSIpAYFmEe-L4fccMJVoAw")]
    [DisplayName("Beneficiary Certification Type13Choice")]
    public abstract record BeneficiaryCertificationType13Choice_ { }
}
