// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType10Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType10Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType10Choice.Code),nameof(BeneficiaryCertificationType10Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType10Choice.Proprietary),nameof(BeneficiaryCertificationType10Choice.Proprietary))]
    [IsoId("_dJFowUGUEeWqy4niLuXETA")]
    [DisplayName("Beneficiary Certification Type 10 Choice")]
    public abstract partial record BeneficiaryCertificationType10Choice_
    {
    }
}
