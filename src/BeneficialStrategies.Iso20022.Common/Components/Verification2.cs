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
[IsoId("_d9Ah4N-rEeelLeeCyrjnCQ")]
[DisplayName("Verification")]
public record Verification2
{
    /// <summary>
    /// Type of authentication or verification.
    /// </summary>
    [IsoId("_eJNK0d-rEeelLeeCyrjnCQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AuthenticationMethod11Code? Type { get; init; }

    /// <summary>
    /// Other type of authentication.
    /// </summary>
    [IsoId("_eJNK09-rEeelLeeCyrjnCQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Type of authentication for a given method (for example, three domain authentication, scheme proprietary solution, type of cryptogram, etc.).
    /// </summary>
    [IsoId("_AuRSkdIpEeirx-13kKhDlQ")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Additional information about the verification.
    /// </summary>
    [IsoId("_eJNK3d-rEeelLeeCyrjnCQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Result of verifications performed prior or after the transaction.
    /// </summary>
    [IsoId("_eJNK4d-rEeelLeeCyrjnCQ")]
    [DisplayName("Verification Result")]
    [IsoXmlTag("VrfctnRslt")]
    public VerificationResult1? VerificationResult { get; init; }
}
