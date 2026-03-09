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
/// Quantity of the financial instrument subscribed.
/// </summary>
[IsoId("_SF2QOtp-Ed-ak6NoX_4Aeg_-1972881267")]
[DisplayName("Financial Instrument Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentQuantity3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentQuantity3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentQuantity3( FinancialInstrumentQuantity1 reqUnitsNumber )
    {
        UnitsNumber = reqUnitsNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_SF2QO9p-Ed-ak6NoX_4Aeg_-1972881242")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1 UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be invested.
    /// </summary>
    [IsoId("_SF2QPNp-Ed-ak6NoX_4Aeg_-1972881182")]
    [DisplayName("Ordered Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrdAmt")]
    #endif
    [IsoXmlTag("OrdrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? OrderedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? OrderedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? OrderedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money as a result of the redemption after deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SF2QPdp-Ed-ak6NoX_4Aeg_-1972881130")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money as a result of the redemption before deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SF2QPtp-Ed-ak6NoX_4Aeg_-1972881051")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money as a result of the redemption.
    /// </summary>
    [IsoId("_SGABMNp-Ed-ak6NoX_4Aeg_-1972880732")]
    [DisplayName("Executed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctdAmt")]
    #endif
    [IsoXmlTag("ExctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ExecutedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ExecutedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ExecutedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_SGABMdp-Ed-ak6NoX_4Aeg_-490894286")]
    [DisplayName("Holdings Redemption Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsRedRate")]
    #endif
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? HoldingsRedemptionRate { get; init; } 
    #else
    public System.Decimal? HoldingsRedemptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SGABMtp-Ed-ak6NoX_4Aeg_-1972880991")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
