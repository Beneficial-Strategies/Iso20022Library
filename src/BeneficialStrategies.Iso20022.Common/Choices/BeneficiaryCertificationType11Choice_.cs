// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType11Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType11Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType11Choice.Code),nameof(BeneficiaryCertificationType11Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType11Choice.Proprietary),nameof(BeneficiaryCertificationType11Choice.Proprietary))]
    [IsoId("_chdlm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Beneficiary Certification Type 11 Choice")]
    public abstract partial record BeneficiaryCertificationType11Choice_
    {
    }
}
