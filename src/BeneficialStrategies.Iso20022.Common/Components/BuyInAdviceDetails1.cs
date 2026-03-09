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
/// Details of a buy-in.
/// </summary>
[IsoId("_fGNv0ZwREeqtp-LOti013g")]
[DisplayName("Buy In Advice Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BuyInAdviceDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BuyInAdviceDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyInAdviceDetails1( References23 reqReference,BuyInState1Code reqBuyInState,BuyInDeferral1Code reqBuyInDeferral )
    {
        Reference = reqReference;
        BuyInState = reqBuyInState;
        BuyInDeferral = reqBuyInDeferral;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// References of the failing transaction.
    /// </summary>
    [IsoId("_fMwct5wREeqtp-LOti013g")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References23 Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References23 Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References23 Reference { get; init; } 
    #else
    public References23 Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the buy-in transaction.
    /// </summary>
    [IsoId("_2kO5cJwREeqtp-LOti013g")]
    [DisplayName("Buy In State")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInStat")]
    #endif
    [IsoXmlTag("BuyInStat")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BuyInState1Code BuyInState { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BuyInState1Code BuyInState { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BuyInState1Code BuyInState { get; init; } 
    #else
    public BuyInState1Code BuyInState { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the buy-in transaction was deferred or not.
    /// </summary>
    [IsoId("_8gDXoJwREeqtp-LOti013g")]
    [DisplayName("Buy In Deferral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInDfrrl")]
    #endif
    [IsoXmlTag("BuyInDfrrl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BuyInDeferral1Code BuyInDeferral { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BuyInDeferral1Code BuyInDeferral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BuyInDeferral1Code BuyInDeferral { get; init; } 
    #else
    public BuyInDeferral1Code BuyInDeferral { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument of the buy-in instruction.
    /// </summary>
    [IsoId("_H0I7ApwSEeqtp-LOti013g")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument concerned by the buy-in transaction.
    /// </summary>
    [IsoId("_JEf6MpwTEeqtp-LOti013g")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the traded financial instrument in the buy-in transaction.
    /// </summary>
    [IsoId("_aU_xoZwTEeqtp-LOti013g")]
    [DisplayName("Buy In Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInPric")]
    #endif
    [IsoXmlTag("BuyInPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat39Choice_? BuyInPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat39Choice_? BuyInPrice { get; init; } 
    #else
    public RateAndAmountFormat39Choice_? BuyInPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that has to be paid by the failing trading party in case of an unsuccessful or partially successful buy-in transaction.
    /// </summary>
    [IsoId("_kcLdAJwTEeqtp-LOti013g")]
    [DisplayName("Cash Compensation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCompstnAmt")]
    #endif
    [IsoXmlTag("CshCompstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection102? CashCompensationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102? CashCompensationAmount { get; init; } 
    #else
    public AmountAndDirection102? CashCompensationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement date of the buy-in. 
    /// </summary>
    [IsoId("_vGqpwpwTEeqtp-LOti013g")]
    [DisplayName("Buy In Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInSttlmDt")]
    #endif
    [IsoXmlTag("BuyInSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? BuyInSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? BuyInSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? BuyInSettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
