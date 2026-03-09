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
[IsoId("_G_iQo35aEea2k7EBUopqxw")]
[DisplayName("Derivative Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeInstrument5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Expiry date of the financial instrument.
    /// </summary>
    [IsoId("_HH3GI35aEea2k7EBUopqxw")]
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
    /// Number of units of the underlying instrument represented by a single derivative contract. For a future or option on an index, the amount per index point.
    /// </summary>
    [IsoId("_HH3GJX5aEea2k7EBUopqxw")]
    [DisplayName("Price Multiplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMltplr")]
    #endif
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.NonNegativeDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNonNegativeDecimalNumber? PriceMultiplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PriceMultiplier { get; init; } 
    #else
    public System.UInt64? PriceMultiplier { get; set; } 
    #endif
    
    /// <summary>
    /// Choice to specify the type(s) of underlying instrument(s) that make up the financial instrument.
    /// </summary>
    [IsoId("_HH3GKX5aEea2k7EBUopqxw")]
    [DisplayName("Underlying Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrm")]
    #endif
    [IsoXmlTag("UndrlygInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentIdentification5Choice_? UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentIdentification5Choice_? UnderlyingInstrument { get; init; } 
    #else
    public FinancialInstrumentIdentification5Choice_? UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// Usage:
    /// Within the scope of MiFIR, RTS 23, the following meanings should be used where a swaption is being detailed, “Put”, in case of receiver swaption, in which the buyer has the right to enter into a swap as a fixed-rate receiver. Call”, in case of payer swaption, in which the buyer has the right to enter into a swap as a fixed-rate payer. Caps and floors shall interpret this field as, &quot;Put”, in case of a Floor, &quot;Call”, in case of a Cap. Field only applies to derivatives that are options or warrants.
    /// </summary>
    [IsoId("_HH3GK35aEea2k7EBUopqxw")]
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
    /// Attributes to specify the strike price of a derivative.
    /// Usage:
    /// Within the scope of MiFIR RTS 23, these are the fields 31 and 32. This field only applies to options, warrants, spread bet on an option on an equity or contract for difference on an option on an equity. Where price is currently not available but pending, the value shall be ’PNDG’. Where strike price is not applicable it shall not be populated.
    /// </summary>
    [IsoId("_HH3GLX5aEea2k7EBUopqxw")]
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
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style).
    /// Usage:
    /// Within the scope of MiFIR, RTS 23, this field is only applicable for options, warrants and entitlement certificates.
    /// </summary>
    [IsoId("_HH3GMX5aEea2k7EBUopqxw")]
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
    [IsoId("_HH3GM35aEea2k7EBUopqxw")]
    [DisplayName("Delivery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTp")]
    #endif
    [IsoXmlTag("DlvryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #else
    public PhysicalTransferType4Code? DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Specific attributes of the underlying asset class of the financial instrument.
    /// </summary>
    [IsoId("_HH3GNX5aEea2k7EBUopqxw")]
    [DisplayName("Asset Class Specific Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClssSpcfcAttrbts")]
    #endif
    [IsoXmlTag("AsstClssSpcfcAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClass2? AssetClassSpecificAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClass2? AssetClassSpecificAttributes { get; init; } 
    #else
    public AssetClass2? AssetClassSpecificAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
