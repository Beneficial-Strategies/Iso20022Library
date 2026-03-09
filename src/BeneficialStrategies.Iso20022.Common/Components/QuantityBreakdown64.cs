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
/// Details of breakdown of a quantity.
/// </summary>
[IsoId("_cabaPzi8Eeydid5dcNPKvg")]
[DisplayName("Quantity Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityBreakdown64
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QuantityBreakdown64 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QuantityBreakdown64( GenericIdentification39 reqLotNumber )
    {
        LotNumber = reqLotNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_cabaQTi8Eeydid5dcNPKvg")]
    [DisplayName("Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotNb")]
    #endif
    [IsoXmlTag("LotNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification39 LotNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification39 LotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification39 LotNumber { get; init; } 
    #else
    public GenericIdentification39 LotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_cabaSTi8Eeydid5dcNPKvg")]
    [DisplayName("Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotQty")]
    #endif
    [IsoXmlTag("LotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity36Choice_? LotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity36Choice_? LotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity36Choice_? LotQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
