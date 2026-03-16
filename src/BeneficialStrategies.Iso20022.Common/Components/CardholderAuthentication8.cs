// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the card and the cardholder.
/// </summary>
[IsoId("_UV3EwYoaEeSirOZJBRz_nA")]
[DisplayName("Cardholder Authentication")]
public record CardholderAuthentication8
{
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer or its card.
    /// </summary>
    [IsoId("_UjTq4YoaEeSirOZJBRz_nA")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod7Code AuthenticationMethod { get; init; }

    /// <summary>
    /// True if an authentication token is requested to the host. This token will be provided to the ATM for further authentication.
    /// </summary>
    [IsoId("_bqLxgIobEeSirOZJBRz_nA")]
    [DisplayName("Token Requested")]
    [IsoXmlTag("TknReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TokenRequested { get; init; }

    /// <summary>
    /// Value or token to be used for customer or card authentication.
    /// </summary>
    [IsoId("_UjTq44oaEeSirOZJBRz_nA")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; }

    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_UjTq5YoaEeSirOZJBRz_nA")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; }

    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_UjTq54oaEeSirOZJBRz_nA")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN5? CardholderOnLinePIN { get; init; }
}
