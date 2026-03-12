// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of beneficiary&apos;s certification.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType1FormatChoice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType1FormatChoice.Code),nameof(BeneficiaryCertificationType1FormatChoice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType1FormatChoice.Proprietary),nameof(BeneficiaryCertificationType1FormatChoice.Proprietary))]
    [IsoId("_RlqUR9p-Ed-ak6NoX_4Aeg_-1197168041")]
    [DisplayName("Beneficiary Certification Type 1 Format Choice")]
    public abstract partial record BeneficiaryCertificationType1FormatChoice_
    {
    }
}
