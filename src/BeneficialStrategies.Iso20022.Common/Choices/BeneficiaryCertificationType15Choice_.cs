// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Beneficiary Certification Type15Choice.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType15Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType15Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType15Choice.Code),
        nameof(BeneficiaryCertificationType15Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType15Choice.Proprietary),
        nameof(BeneficiaryCertificationType15Choice.Proprietary)
    )]
    [IsoId("_nLhtVZt3Ee-wQIOX0djF2w")]
    [DisplayName("Beneficiary Certification Type15Choice")]
    public abstract record BeneficiaryCertificationType15Choice_ { }
}
