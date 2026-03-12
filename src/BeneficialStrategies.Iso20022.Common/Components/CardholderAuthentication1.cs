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
[IsoId("_SqIIxQEcEeCQm6a_G2yO_w_-1322900319")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication1
{
    #nullable enable
    
    /// <summary>
    /// Method used to authenticate a cardholder.
    /// </summary>
    [IsoId("_SqIIxgEcEeCQm6a_G2yO_w_-987531506")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod1Code AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_SqIIxwEcEeCQm6a_G2yO_w_552916145")]
    [DisplayName("Authentication Entity")]
    [IsoXmlTag("AuthntcnNtty")]
    public required AuthenticationEntity1Code AuthenticationEntity { get; init; } 
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_SqIIyAEcEeCQm6a_G2yO_w_1343689902")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public IsoMax40Text? AuthenticationValue { get; init; } 
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_SqIIyQEcEeCQm6a_G2yO_w_2077150585")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN1? CardholderOnLinePIN { get; init; } 
    
    /// <summary>
    /// Identifies in electronic commerce transactions whether customer authentication is supported and data is available.
    /// </summary>
    [IsoId("_SqIIygEcEeCQm6a_G2yO_w_-649196654")]
    [DisplayName("Authentication Collection Indicator")]
    [IsoXmlTag("AuthntcnColltnInd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AuthenticationCollectionIndicator { get; init; } 
    
    
    #nullable disable
    
}
