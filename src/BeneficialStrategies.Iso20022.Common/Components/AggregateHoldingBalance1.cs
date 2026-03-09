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
/// Overall holding position, in a single financial instrument, held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_-x81hmZ5EeSPkYKcdPbJxw")]
[DisplayName("Aggregate Holding Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateHoldingBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateHoldingBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateHoldingBalance1( SecurityIdentification19 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument for which the balance information is specified.
    /// </summary>
    [IsoId("_-x81iGZ5EeSPkYKcdPbJxw")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Form of ownership of the holding.
    /// </summary>
    [IsoId("_-x81iWZ5EeSPkYKcdPbJxw")]
    [DisplayName("Holding Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgForm")]
    #endif
    [IsoXmlTag("HldgForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? HoldingForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? HoldingForm { get; init; } 
    #else
    public FormOfSecurity1Code? HoldingForm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the holding is physically delivered or is a book entry only.
    /// </summary>
    [IsoId("_-x81i2Z5EeSPkYKcdPbJxw")]
    [DisplayName("Holding Physical Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgPhysTp")]
    #endif
    [IsoXmlTag("HldgPhysTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType1Code? HoldingPhysicalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType1Code? HoldingPhysicalType { get; init; } 
    #else
    public PhysicalTransferType1Code? HoldingPhysicalType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance breakdown on the net position of the financial instrument.
    /// </summary>
    [IsoId("_-x81imZ5EeSPkYKcdPbJxw")]
    [DisplayName("Balance For Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForFinInstrm")]
    #endif
    [IsoXmlTag("BalForFinInstrm")]
    public ValueList<FinancialInstrumentAggregateBalance1> BalanceForFinancialInstrument { get; init; } = new ValueList<FinancialInstrumentAggregateBalance1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-x81imZ5EeSPkYKcdPbJxw
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_-x81h2Z5EeSPkYKcdPbJxw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
