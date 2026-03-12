// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction entry.
/// </summary>
[IsoId("_t6PVslkyEeGeoaLUQk__nA_118964037")]
[DisplayName("Card Entry")]
public partial record CardEntry1
{
    #nullable enable
    
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_t6PVs1kyEeGeoaLUQk__nA_458882299")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; } 
    
    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_t6ZGsFkyEeGeoaLUQk__nA_1876471602")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; } 
    
    /// <summary>
    /// Card entry details, based on card transaction aggregated data performed by the account servicer.
    /// </summary>
    [IsoId("_t6ZGsVkyEeGeoaLUQk__nA_-2135334410")]
    [DisplayName("Aggregated Entry")]
    [IsoXmlTag("AggtdNtry")]
    public CardAggregated1? AggregatedEntry { get; init; } 
    
    
    #nullable disable
    
}
