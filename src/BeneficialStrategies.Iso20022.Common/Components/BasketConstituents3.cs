// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
/// </summary>
[IsoId("_t3aoASyGEe2xAdY9t5fB3g")]
[DisplayName("Basket Constituents")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BasketConstituents3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BasketConstituents3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BasketConstituents3( InstrumentIdentification6Choice_ reqInstrumentIdentification )
    {
        InstrumentIdentification = reqInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_t4Q8kSyGEe2xAdY9t5fB3g")]
    [DisplayName("Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmId")]
    #endif
    [IsoXmlTag("InstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstrumentIdentification6Choice_ InstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstrumentIdentification6Choice_ InstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstrumentIdentification6Choice_ InstrumentIdentification { get; init; } 
    #else
    public InstrumentIdentification6Choice_ InstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the number of units of a particular constituent in a custom basket.
    /// </summary>
    [IsoId("_t4Q8kyyGEe2xAdY9t5fB3g")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction19DecimalNumber? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Quantity { get; init; } 
    #else
    public System.UInt64? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unit of measure in which the number of units of a particular custom basket constituent is expressed.
    /// </summary>
    [IsoId("_t4Q8lSyGEe2xAdY9t5fB3g")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
