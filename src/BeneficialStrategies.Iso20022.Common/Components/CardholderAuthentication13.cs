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
[IsoId("_-PhO4QxuEeqdx6buGpCCQw")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication13
{
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_-bf1YQxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// If Strong Customer Authentication is not mandated to process the transaction, this message element must identify the reason of exemption.
    /// </summary>
    [IsoId("_2jG4oAx1Eeqdx6buGpCCQw")]
    [DisplayName("Authentication Exemption")]
    [IsoXmlTag("AuthntcnXmptn")]
    public Exemption1Code? AuthenticationExemption { get; init; } 
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_-bf1YwxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_-bf1ZQxuEeqdx6buGpCCQw")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType22? ProtectedAuthenticationValue { get; init; } 
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_-bf1ZwxuEeqdx6buGpCCQw")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN7? CardholderOnLinePIN { get; init; } 
    
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_-bf1aQxuEeqdx6buGpCCQw")]
    [DisplayName("Cardholder Identification")]
    [IsoXmlTag("CrdhldrId")]
    public PersonIdentification15? CardholderIdentification { get; init; } 
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_-bf1awxuEeqdx6buGpCCQw")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; } 
    
    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    [IsoId("_-bf1bQxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Type")]
    [IsoXmlTag("AuthntcnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationType { get; init; } 
    
    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    [IsoId("_-bf1bwxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Level")]
    [IsoXmlTag("AuthntcnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationLevel { get; init; } 
    
    /// <summary>
    /// Result of authentication.
    /// </summary>
    [IsoId("_-bf1cQxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    
    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    [IsoId("_-bf1cwxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Additional Information")]
    [IsoXmlTag("AuthntcnAddtlInf")]
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
