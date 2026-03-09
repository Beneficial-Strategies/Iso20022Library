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
/// Specifies the derivative instrument.
/// </summary>
[IsoId("_1V6QYZ3DEeuwmdq0KtnICg")]
[DisplayName("Derivative Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeInstrument9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeInstrument9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeInstrument9( System.UInt64 reqPriceMultiplier,UnderlyingIdentification3Choice_ reqUnderlyingInstrument,PhysicalTransferType4Code reqDeliveryType )
    {
        PriceMultiplier = reqPriceMultiplier;
        UnderlyingInstrument = reqUnderlyingInstrument;
        DeliveryType = reqDeliveryType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Original expiry date of the reported financial instrument. 
    /// Usage:
    /// Field applies to derivatives with defined expiry date.
    /// </summary>
    [IsoId("_1tAhwZ3DEeuwmdq0KtnICg")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpiryDate { get; init; } 
    #else
    public System.DateOnly? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// For a future or option on an index, the amount per index point.
    /// </summary>
    [IsoId("_1tAhw53DEeuwmdq0KtnICg")]
    [DisplayName("Price Multiplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMltplr")]
    #endif
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.NonNegativeDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNonNegativeDecimalNumber PriceMultiplier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 PriceMultiplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 PriceMultiplier { get; init; } 
    #else
    public System.UInt64 PriceMultiplier { get; set; } 
    #endif
    
    /// <summary>
    /// Choice to specify the type(s) of underlying instrument(s) that make up the financial instrument.
    /// </summary>
    [IsoId("_1tAhx53DEeuwmdq0KtnICg")]
    [DisplayName("Underlying Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrm")]
    #endif
    [IsoXmlTag("UndrlygInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingIdentification3Choice_ UnderlyingInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingIdentification3Choice_ UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingIdentification3Choice_ UnderlyingInstrument { get; init; } 
    #else
    public UnderlyingIdentification3Choice_ UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_1tAhyZ3DEeuwmdq0KtnICg")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType2Code? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType2Code? OptionType { get; init; } 
    #else
    public OptionType2Code? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_1tAhy53DEeuwmdq0KtnICg")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice4Choice_? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice4Choice_? StrikePrice { get; init; } 
    #else
    public SecuritiesTransactionPrice4Choice_? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    [IsoId("_1tAhz53DEeuwmdq0KtnICg")]
    [DisplayName("Option Exercise Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnExrcStyle")]
    #endif
    [IsoXmlTag("OptnExrcStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle7Code? OptionExerciseStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle7Code? OptionExerciseStyle { get; init; } 
    #else
    public OptionStyle7Code? OptionExerciseStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is settled physically or in cash.
    /// </summary>
    [IsoId("_1tAh0Z3DEeuwmdq0KtnICg")]
    [DisplayName("Delivery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTp")]
    #endif
    [IsoXmlTag("DlvryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PhysicalTransferType4Code DeliveryType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PhysicalTransferType4Code DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType4Code DeliveryType { get; init; } 
    #else
    public PhysicalTransferType4Code DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Specific attributes of the underlying asset class of the financial instrument.
    /// </summary>
    [IsoId("_1tAh053DEeuwmdq0KtnICg")]
    [DisplayName("Asset Class Specific Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClssSpcfcAttrbts")]
    #endif
    [IsoXmlTag("AsstClssSpcfcAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassAttributes1Choice_? AssetClassSpecificAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassAttributes1Choice_? AssetClassSpecificAttributes { get; init; } 
    #else
    public AssetClassAttributes1Choice_? AssetClassSpecificAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
