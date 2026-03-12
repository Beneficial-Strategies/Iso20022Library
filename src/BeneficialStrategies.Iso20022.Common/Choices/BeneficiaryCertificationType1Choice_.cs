// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType1Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType1Choice.Code),nameof(BeneficiaryCertificationType1Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType1Choice.Proprietary),nameof(BeneficiaryCertificationType1Choice.Proprietary))]
    [IsoId("_Q0CqFdp-Ed-ak6NoX_4Aeg_-101661289")]
    [DisplayName("Beneficiary Certification Type 1 Choice")]
    public abstract partial record BeneficiaryCertificationType1Choice_
    {
    }
}
