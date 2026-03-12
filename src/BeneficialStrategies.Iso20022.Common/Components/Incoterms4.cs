// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the applicable Incoterm and associated location.
/// </summary>
[IsoId("_pdzLMValEeOkkLyrDUP66g")]
[DisplayName("Incoterms")]
public partial record Incoterms4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the Incoterms.
    /// </summary>
    [IsoId("_ps-PoValEeOkkLyrDUP66g")]
    [DisplayName("Incoterms Code")]
    [IsoXmlTag("IncotrmsCd")]
    public required Incoterms4Choice_ IncotermsCode { get; init; } 
    
    /// <summary>
    /// Location where the Incoterms are actioned. Reference UN/ECE Recommendation 16 - LOCODE - Code for Trade and Transport Locations (www.unece.org/cefact/recommendations).
    /// </summary>
    [IsoId("_ps-Po1alEeOkkLyrDUP66g")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Location { get; init; } 
    
    
    #nullable disable
    
}
