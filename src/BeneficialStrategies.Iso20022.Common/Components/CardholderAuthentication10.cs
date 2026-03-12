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
[IsoId("_RprEsLACEeah1_v59tW6Rg")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication10
{
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_R4T9obACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod5Code AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_R4T9o7ACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_R4T9pbACEeah1_v59tW6Rg")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; } 
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_R4T9p7ACEeah1_v59tW6Rg")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN4? CardholderOnLinePIN { get; init; } 
    
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_R4T9qbACEeah1_v59tW6Rg")]
    [DisplayName("Cardholder Identification")]
    [IsoXmlTag("CrdhldrId")]
    public PersonIdentification11? CardholderIdentification { get; init; } 
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_R4T9q7ACEeah1_v59tW6Rg")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; } 
    
    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    [IsoId("_dkoa0LACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Type")]
    [IsoXmlTag("AuthntcnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationType { get; init; } 
    
    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    [IsoId("_kTh7wLACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Level")]
    [IsoXmlTag("AuthntcnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationLevel { get; init; } 
    
    /// <summary>
    /// Result of authentication.
    /// </summary>
    [IsoId("_sXw38LACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    
    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    [IsoId("_48zs4LACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Additional Information")]
    [IsoXmlTag("AuthntcnAddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationAdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
