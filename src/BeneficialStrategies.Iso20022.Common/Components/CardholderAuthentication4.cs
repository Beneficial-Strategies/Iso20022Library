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
[IsoId("_Zcd9gTSKEeK8M6X9iBRU5A")]
[DisplayName("Cardholder Authentication")]
public partial record CardholderAuthentication4
{
    #nullable enable
    
    /// <summary>
    /// Method used to authenticate the cardholder.
    /// </summary>
    [IsoId("_Zmbx0TSKEeK8M6X9iBRU5A")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod2Code AuthenticationMethod { get; init; } 
    
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_Zmbx1TSKEeK8M6X9iBRU5A")]
    [DisplayName("Authentication Entity")]
    [IsoXmlTag("AuthntcnNtty")]
    public required AuthenticationEntity1Code AuthenticationEntity { get; init; } 
    
    
    #nullable disable
    
}
