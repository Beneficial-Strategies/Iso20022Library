// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
/// </summary>
[IsoId("_t3aoASyGEe2xAdY9t5fB3g")]
[DisplayName("Basket Constituents")]
public partial record BasketConstituents3
{
    #nullable enable
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_t4Q8kSyGEe2xAdY9t5fB3g")]
    [DisplayName("Instrument Identification")]
    [IsoXmlTag("InstrmId")]
    public required InstrumentIdentification6Choice_ InstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the number of units of a particular constituent in a custom basket.
    /// </summary>
    [IsoId("_t4Q8kyyGEe2xAdY9t5fB3g")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? Quantity { get; init; } 
    
    /// <summary>
    /// Specifies the unit of measure in which the number of units of a particular custom basket constituent is expressed.
    /// </summary>
    [IsoId("_t4Q8lSyGEe2xAdY9t5fB3g")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    
    
    #nullable disable
    
}
