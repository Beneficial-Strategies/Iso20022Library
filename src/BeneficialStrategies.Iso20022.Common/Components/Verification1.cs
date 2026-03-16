// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Method and data intended to be verified as well as the related results.
/// </summary>
[IsoId("_aIR0sEbcEeeIjf8aP9KbJA")]
[DisplayName("Verification")]
public record Verification1
{
    /// <summary>
    /// Type of authentication or verification.
    /// </summary>
    [IsoId("_0ZNx4EbcEeeIjf8aP9KbJA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AuthenticationMethod11Code? Type { get; init; }

    /// <summary>
    /// Other type of authentication or verification.
    /// </summary>
    [IsoId("_7xHzkEbcEeeIjf8aP9KbJA")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Type of authentication for a given method (for example, three domain authentication, scheme proprietary solution, type of cryptogram, etc.).
    /// </summary>
    [IsoId("_RkuCwEbdEeeIjf8aP9KbJA")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Contains verification or authentication data.
    /// </summary>
    [IsoId("_qxdYAEbdEeeIjf8aP9KbJA")]
    [DisplayName("Verification Information")]
    [IsoXmlTag("VrfctnInf")]
    public VerificationInformation1? VerificationInformation { get; init; }

    /// <summary>
    /// Result of verifications performed prior or after the transaction.
    /// ISO 8583:93 bit 39
    /// ISO 8583:2003 bit 39 &amp; 49-72
    /// </summary>
    [IsoId("_Ouws0EbeEeeIjf8aP9KbJA")]
    [DisplayName("Verification Result")]
    [IsoXmlTag("VrfctnRslt")]
    public VerificationResult1? VerificationResult { get; init; }
}
