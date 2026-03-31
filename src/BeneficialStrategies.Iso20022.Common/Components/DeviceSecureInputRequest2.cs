// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request a secure input for a PIN.
/// </summary>
[IsoId("_7aowkQ0rEeqUVL7sB4m7NA")]
[DisplayName("Device Secure Input Request")]
public record DeviceSecureInputRequest2
{
    /// <summary>
    /// Type of PIN Service.
    /// </summary>
    [IsoId("_7mYGgQ0rEeqUVL7sB4m7NA")]
    [DisplayName("PIN Request Type")]
    [IsoXmlTag("PINReqTp")]
    public required PINRequestType1Code PINRequestType { get; init; }

    /// <summary>
    /// Identify the PIN verification method and keys.
    /// </summary>
    [IsoId("_7mYGgw0rEeqUVL7sB4m7NA")]
    [DisplayName("PIN Verification Method")]
    [IsoXmlTag("PINVrfctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PINVerificationMethod { get; init; }

    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_7mYGhQ0rEeqUVL7sB4m7NA")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; }

    /// <summary>
    /// Indicates, when the user press a key, if a beep has to be generated.
    /// </summary>
    [IsoId("_7mYGhw0rEeqUVL7sB4m7NA")]
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; }

    /// <summary>
    /// Enciphered PIN and related information.
    /// </summary>
    [IsoId("_7mYGiQ0rEeqUVL7sB4m7NA")]
    [DisplayName("Cardholder PIN")]
    [IsoXmlTag("CrdhldrPIN")]
    public OnLinePIN7? CardholderPIN { get; init; }
}
