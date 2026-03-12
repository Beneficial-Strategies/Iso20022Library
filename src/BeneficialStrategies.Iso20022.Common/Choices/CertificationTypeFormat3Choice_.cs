// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the certification format required.
    /// </summary>
    [KnownType(typeof(CertificationTypeFormat3Choice.Code))]
    [KnownType(typeof(CertificationTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(CertificationTypeFormat3Choice.Code),nameof(CertificationTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(CertificationTypeFormat3Choice.Proprietary),nameof(CertificationTypeFormat3Choice.Proprietary))]
    [IsoId("_bZ7v0UEGEeWVgfuHGaKtRQ")]
    [DisplayName("Certification Type Format 3 Choice")]
    public abstract partial record CertificationTypeFormat3Choice_
    {
    }
}
