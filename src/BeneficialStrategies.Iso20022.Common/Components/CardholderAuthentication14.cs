// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_L0J68S8qEeu125Ip9zFcsQ")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication14
{
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_MBJOES8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// If Strong Customer Authentication is not mandated to process the transaction, this message element must identify the reason of exemption.
    /// </summary>
    [IsoId("_MBJOEy8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Exemption")]
    [IsoXmlTag("AuthntcnXmptn")]
    public Exemption1Code? AuthenticationExemption { get; init; } 
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_MBJOFS8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_MBJOFy8qEeu125Ip9zFcsQ")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType28? ProtectedAuthenticationValue { get; init; } 
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_MBJOGS8qEeu125Ip9zFcsQ")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN8? CardholderOnLinePIN { get; init; } 
    
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_MBJOGy8qEeu125Ip9zFcsQ")]
    [DisplayName("Cardholder Identification")]
    [IsoXmlTag("CrdhldrId")]
    public PersonIdentification15? CardholderIdentification { get; init; } 
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_MBJOHS8qEeu125Ip9zFcsQ")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; } 
    
    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    [IsoId("_MBJOHy8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Type")]
    [IsoXmlTag("AuthntcnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationType { get; init; } 
    
    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    [IsoId("_MBJOIS8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Level")]
    [IsoXmlTag("AuthntcnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationLevel { get; init; } 
    
    /// <summary>
    /// Result of authentication.
    /// </summary>
    [IsoId("_MBJOIy8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    
    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    [IsoId("_MBJOJS8qEeu125Ip9zFcsQ")]
    [DisplayName("Authentication Additional Information")]
    [IsoXmlTag("AuthntcnAddtlInf")]
    public ExternallyDefinedData2? AuthenticationAdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
