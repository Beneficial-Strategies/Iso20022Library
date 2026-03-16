// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType2Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType2Choice.Code),
        nameof(BeneficiaryCertificationType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BeneficiaryCertificationType2Choice.Proprietary),
        nameof(BeneficiaryCertificationType2Choice.Proprietary)
    )]
    [IsoId("_QzTDNdp-Ed-ak6NoX_4Aeg_-1272152318")]
    [DisplayName("Beneficiary Certification Type 2 Choice")]
    public abstract record BeneficiaryCertificationType2Choice_ { }
}
