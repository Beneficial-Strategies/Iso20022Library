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
/// DTC (The Depository Trust Company) Tax Relief service election details.
/// </summary>
[IsoId("_1b3BsjL3EeKU9IrkkToqcw_-1727266611")]
[DisplayName("DTC Tax Relief SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCTaxReliefSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DTCTaxReliefSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DTCTaxReliefSD2( System.String reqPlaceAndName,DTCTaxReliefSD1 reqDTCTaxReliefCategory,FinancialInstrumentQuantity15Choice_ reqInstructionQuantity )
    {
        PlaceAndName = reqPlaceAndName;
        DTCTaxReliefCategory = reqDTCTaxReliefCategory;
        InstructionQuantity = reqInstructionQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1b3BszL3EeKU9IrkkToqcw_892961340")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the defined tax relief categories used by DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1b3BtDL3EeKU9IrkkToqcw_1733228081")]
    [DisplayName("DTC Tax Relief Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCTaxRlfCtgy")]
    #endif
    [IsoXmlTag("DTCTaxRlfCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCTaxReliefSD1 DTCTaxReliefCategory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCTaxReliefSD1 DTCTaxReliefCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCTaxReliefSD1 DTCTaxReliefCategory { get; init; } 
    #else
    public DTCTaxReliefSD1 DTCTaxReliefCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed quantity for DTC Tax Relief service elections.
    /// </summary>
    [IsoId("_1b3BtTL3EeKU9IrkkToqcw_-633817074")]
    [DisplayName("Instruction Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrQty")]
    #endif
    [IsoXmlTag("InstrQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
