// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Beneficiary Certification Type14Choice.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType14Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType14Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType14Choice.Code),nameof(BeneficiaryCertificationType14Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType14Choice.Proprietary),nameof(BeneficiaryCertificationType14Choice.Proprietary))]
    [IsoId("_l6TU95t3Ee-wQIOX0djF2w")]
    [DisplayName("Beneficiary Certification Type14Choice")]
    public abstract partial record BeneficiaryCertificationType14Choice_
    {
    }
}
