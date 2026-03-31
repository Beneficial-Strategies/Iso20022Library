// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_uzlg0YIDEeS7UOLM47txvA")]
[DisplayName("Cardholder Authentication")]
public record CardholderAuthentication7
{
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_vAjl0YIDEeS7UOLM47txvA")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod5Code AuthenticationMethod { get; init; }

    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_vAjl04IDEeS7UOLM47txvA")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; }

    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_vAjl1YIDEeS7UOLM47txvA")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; }

    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_vAjl14IDEeS7UOLM47txvA")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN4? CardholderOnLinePIN { get; init; }

    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_vB3IkC-2EeWfYucYWs4iQg")]
    [DisplayName("Cardholder Identification")]
    [IsoXmlTag("CrdhldrId")]
    public PersonIdentification7? CardholderIdentification { get; init; }

    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_vAjl2YIDEeS7UOLM47txvA")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }
}
