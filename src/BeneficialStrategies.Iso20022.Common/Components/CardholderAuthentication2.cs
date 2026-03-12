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
[IsoId("_SqbqyQEcEeCQm6a_G2yO_w_-1688249611")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication2
{
    #nullable enable
    
    /// <summary>
    /// Method used to authenticate the cardholder.
    /// </summary>
    [IsoId("_SqbqygEcEeCQm6a_G2yO_w_-169558028")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod1Code AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_SqbqywEcEeCQm6a_G2yO_w_-1371836971")]
    [DisplayName("Authentication Entity")]
    [IsoXmlTag("AuthntcnNtty")]
    public required AuthenticationEntity1Code AuthenticationEntity { get; init; } 
    
    
    #nullable disable
    
}
