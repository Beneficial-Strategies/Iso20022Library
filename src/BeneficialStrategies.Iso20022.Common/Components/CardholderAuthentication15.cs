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
[IsoId("_6InQQVFCEeyApZmLzm74zA")]
[DisplayName("Cardholder Authentication")]
public record CardholderAuthentication15
{
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_6PD2gVFCEeyApZmLzm74zA")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; }

    /// <summary>
    /// If Strong Customer Authentication is not mandated to process the transaction, this message element must identify the reason of exemption.
    /// </summary>
    [IsoId("_6PD2g1FCEeyApZmLzm74zA")]
    [DisplayName("Authentication Exemption")]
    [IsoXmlTag("AuthntcnXmptn")]
    public Exemption1Code? AuthenticationExemption { get; init; }

    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_6PD2hVFCEeyApZmLzm74zA")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; }

    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_6PD2h1FCEeyApZmLzm74zA")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType32? ProtectedAuthenticationValue { get; init; }

    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_6PD2iVFCEeyApZmLzm74zA")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN9? CardholderOnLinePIN { get; init; }

    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_6PD2i1FCEeyApZmLzm74zA")]
    [DisplayName("Cardholder Identification")]
    [IsoXmlTag("CrdhldrId")]
    public PersonIdentification15? CardholderIdentification { get; init; }

    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_6PD2jVFCEeyApZmLzm74zA")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }

    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    [IsoId("_6PD2j1FCEeyApZmLzm74zA")]
    [DisplayName("Authentication Type")]
    [IsoXmlTag("AuthntcnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AuthenticationType { get; init; }

    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    [IsoId("_6PD2kVFCEeyApZmLzm74zA")]
    [DisplayName("Authentication Level")]
    [IsoXmlTag("AuthntcnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AuthenticationLevel { get; init; }

    /// <summary>
    /// Result of authentication.
    /// </summary>
    [IsoId("_6PD2k1FCEeyApZmLzm74zA")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public AuthenticationResult1Code? AuthenticationResult { get; init; }

    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    [IsoId("_6PD2lVFCEeyApZmLzm74zA")]
    [DisplayName("Authentication Additional Information")]
    [IsoXmlTag("AuthntcnAddtlInf")]
    public ExternallyDefinedData3? AuthenticationAdditionalInformation { get; init; }
}
