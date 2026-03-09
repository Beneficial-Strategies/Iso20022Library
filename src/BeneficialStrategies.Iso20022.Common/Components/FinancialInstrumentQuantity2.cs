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
[IsoId("_SGABM9p-Ed-ak6NoX_4Aeg_345752631")]
[DisplayName("Financial Instrument Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentQuantity2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentQuantity2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentQuantity2( FinancialInstrumentQuantity1 reqUnitsNumber )
    {
        UnitsNumber = reqUnitsNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_SGABNNp-Ed-ak6NoX_4Aeg_345752649")]
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
    [IsoId("_SGABNdp-Ed-ak6NoX_4Aeg_345752726")]
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
    /// Amount of money invested after deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SGABNtp-Ed-ak6NoX_4Aeg_345753034")]
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
    /// Amount of money invested before deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SGABN9p-Ed-ak6NoX_4Aeg_345753284")]
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
    /// Amount of money invested.
    /// </summary>
    [IsoId("_SGABONp-Ed-ak6NoX_4Aeg_1692243831")]
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
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SGABOdp-Ed-ak6NoX_4Aeg_1448437730")]
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
