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
[IsoId("_S5VCYwEcEeCQm6a_G2yO_w_154174815")]
[DisplayName("Incoterms")]
public partial record Incoterms3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the Incoterms.
    /// </summary>
    [IsoId("_S5VCZAEcEeCQm6a_G2yO_w_129737747")]
    [DisplayName("Incoterms Code")]
    [IsoXmlTag("IncotrmsCd")]
    public required Incoterms4Choice_ IncotermsCode { get; init; } 
    
    /// <summary>
    /// Location where the Incoterms are actioned. Reference UN/ECE Recommendation 16 - LOCODE - Code for Trade and Transport Locations (www.unece.org/cefact/recommendations).
    /// </summary>
    [IsoId("_S5VCZQEcEeCQm6a_G2yO_w_-956736604")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Location { get; init; } 
    
    
    #nullable disable
    
}
