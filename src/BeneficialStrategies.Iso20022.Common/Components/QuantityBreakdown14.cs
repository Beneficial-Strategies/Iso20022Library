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
[IsoId("_0L7B9__pEeCiHMrKuf9tBw")]
[DisplayName("Quantity Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityBreakdown14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_0L7CAf_pEeCiHMrKuf9tBw")]
    [DisplayName("Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotNb")]
    #endif
    [IsoXmlTag("LotNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? LotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? LotNumber { get; init; } 
    #else
    public GenericIdentification37? LotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_0L7CC__pEeCiHMrKuf9tBw")]
    [DisplayName("Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotQty")]
    #endif
    [IsoXmlTag("LotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_0L7CFf_pEeCiHMrKuf9tBw")]
    [DisplayName("Lot Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotDtTm")]
    #endif
    [IsoXmlTag("LotDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? LotDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? LotDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? LotDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_0L7CH__pEeCiHMrKuf9tBw")]
    [DisplayName("Lot Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotPric")]
    #endif
    [IsoXmlTag("LotPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? LotPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? LotPrice { get; init; } 
    #else
    public Price2? LotPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_0L7CKf_pEeCiHMrKuf9tBw")]
    [DisplayName("Type Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfPric")]
    #endif
    [IsoXmlTag("TpOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice3Choice_? TypeOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    [IsoId("_0L7CM__pEeCiHMrKuf9tBw")]
    [DisplayName("Account Base Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBaseCcyAmts")]
    #endif
    [IsoXmlTag("AcctBaseCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_0L7CPf_pEeCiHMrKuf9tBw")]
    [DisplayName("Instrument Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmCcyAmts")]
    #endif
    [IsoXmlTag("InstrmCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation amounts for the lot provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_0L7CR__pEeCiHMrKuf9tBw")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnRptgCcyAmts")]
    #endif
    [IsoXmlTag("AltrnRptgCcyAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; init; } 
    #else
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; set; } 
    #endif
    
    
    #nullable disable
    
}
