// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType12Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType12Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType12Choice.Code),nameof(BeneficiaryCertificationType12Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType12Choice.Proprietary),nameof(BeneficiaryCertificationType12Choice.Proprietary))]
    [IsoId("_cta-Q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Beneficiary Certification Type 12 Choice")]
    public abstract partial record BeneficiaryCertificationType12Choice_
    {
    }
}
