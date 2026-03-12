// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security by its symbol.
/// </summary>
[IsoId("_el9wcID3EeSQoe-8fZQlpA")]
[DisplayName("Security Identification")]
public partial record SecurityIdentification18
{
    #nullable enable
    
    /// <summary>
    /// Security identification source of the trade.
    /// </summary>
    [IsoId("_q2VgcID4EeSQoe-8fZQlpA")]
    [DisplayName("Security Identification Source")]
    [IsoXmlTag("SctyIdSrc")]
    public required IdentificationType2Code SecurityIdentificationSource { get; init; } 
    
    /// <summary>
    /// Security identification of the trade.
    /// </summary>
    [IsoId("_vO8fcID4EeSQoe-8fZQlpA")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SecurityIdentification { get; init; } 
    
    
    #nullable disable
    
}
