// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains details about called certificates.
/// </summary>
[IsoId("_1VdexDL3EeKU9IrkkToqcw_-1325892976")]
[DisplayName("Corporate Action SD")]
public record CorporateActionSD5
{
    /// <summary>
    /// Unique identification or serial number that is assigned and affixed by an issuer or transfer agent to each securities certificate.
    /// </summary>
    [IsoId("_1VdexTL3EeKU9IrkkToqcw_1892750447")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText CertificateNumber { get; init; }

    /// <summary>
    /// Principal amount (for debt issues) or number of shares (for equity issues) that has been called for redemption for a particular certificate number.
    /// </summary>
    [IsoId("_1VmosDL3EeKU9IrkkToqcw_1945798532")]
    [DisplayName("Certificate Called Amount")]
    [IsoXmlTag("CertClldAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber CertificateCalledAmount { get; init; }
}
