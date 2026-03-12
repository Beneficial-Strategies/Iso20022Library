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
[IsoId("_HE--UWjNEeSHBr6v3XO0Mg")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication6
{
    #nullable enable
    
    /// <summary>
    /// Method to authenticate the cardholder.
    /// </summary>
    [IsoId("_HSU2wWjNEeSHBr6v3XO0Mg")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod3Code AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_HSU2xWjNEeSHBr6v3XO0Mg")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_F7UVoGjPEeSHBr6v3XO0Mg")]
    [DisplayName("Protected Authentication Value")]
    [IsoXmlTag("PrtctdAuthntcnVal")]
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; } 
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_HSU2x2jNEeSHBr6v3XO0Mg")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN4? CardholderOnLinePIN { get; init; } 
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_q8ZboGjPEeSHBr6v3XO0Mg")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; } 
    
    
    #nullable disable
    
}
