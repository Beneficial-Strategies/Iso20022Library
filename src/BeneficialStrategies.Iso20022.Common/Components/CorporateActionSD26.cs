// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action SD26.
/// </summary>
[IsoId("_-SiQkaD9Ee-4O7NbwmwJkQ")]
[DisplayName("Corporate Action SD26")]
public record CorporateActionSD26
{
    /// <summary>
    /// Certificate Called Amount.
    /// </summary>
    [DisplayName("Certificate Called Amount")]
    [IsoXmlTag("CertClldAmt")]
    public required IsoDecimalNumber CertificateCalledAmount { get; init; }

    /// <summary>
    /// Certificate Number.
    /// </summary>
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public required IsoMax15AlphaNumericText CertificateNumber { get; init; }

    /// <summary>
    /// Certificate Prefix.
    /// </summary>
    [DisplayName("Certificate Prefix")]
    [IsoXmlTag("CertPrfx")]
    public IsoMax4AlphaNumericText? CertificatePrefix { get; init; }
}
