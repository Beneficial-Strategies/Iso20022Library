// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cardholder Authentication17.
/// </summary>
[IsoId("_E0EvcZCVEe6zroekBXoFoQ")]
[DisplayName("Cardholder Authentication17")]
public record CardholderAuthentication17
{
    /// <summary>
    /// Address Verification.
    /// </summary>
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }

    /// <summary>
    /// Authentication Additional Information.
    /// </summary>
    [DisplayName("Authentication Additional Information")]
    [IsoXmlTag("AuthntcnAddtlInf")]
    public ExternallyDefinedData5? AuthenticationAdditionalInformation { get; init; }

    /// <summary>
    /// Authentication Exemption.
    /// </summary>
    [DisplayName("Authentication Exemption")]
    [IsoXmlTag("AuthntcnXmptn")]
    public Exemption1Code? AuthenticationExemption { get; init; }

    /// <summary>
    /// Authentication Level.
    /// </summary>
    [DisplayName("Authentication Level")]
    [IsoXmlTag("AuthntcnLvl")]
    public IsoMax35Text? AuthenticationLevel { get; init; }

    /// <summary>
    /// Authentication Method.
    /// </summary>
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; }

    /// <summary>
    /// Authentication Result.
    /// </summary>
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public AuthenticationResult1Code? AuthenticationResult { get; init; }

    /// <summary>
    /// Authentication Type.
    /// </summary>
    [DisplayName("Authentication Type")]
    [IsoXmlTag("AuthntcnTp")]
    public IsoMax35Text? AuthenticationType { get; init; }

    /// <summary>
    /// Authentication Value.
    /// </summary>
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    public IsoMax5000Binary? AuthenticationValue { get; init; }

    /// <summary>
    /// Cardholder Identification.
    /// </summary>
    [DisplayName("Cardholder Identification")]
    [IsoXmlTag("CrdhldrId")]
    public PersonIdentification15? CardholderIdentification { get; init; }

    /// <summary>
    /// Cardholder On Line PIN.
    /// </summary>
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN11? CardholderOnLinePIN { get; init; }

    /// <summary>
    /// Protected Authentication Value.
    /// </summary>
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType40? ProtectedAuthenticationValue { get; init; }
}
