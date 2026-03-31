// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the certification format required.
    /// </summary>
    [KnownType(typeof(CertificationTypeFormat4Choice.Code))]
    [KnownType(typeof(CertificationTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CertificationTypeFormat4Choice.Code),
        nameof(CertificationTypeFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CertificationTypeFormat4Choice.Proprietary),
        nameof(CertificationTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_c5WhW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Certification Type Format 4 Choice")]
    public abstract record CertificationTypeFormat4Choice_ { }
}
