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
/// Set of elements providing information on the original amount and currency information.
/// </summary>
[IsoId("_SVf1xNp-Ed-ak6NoX_4Aeg_1205555994")]
[DisplayName("Amount And Currency Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndCurrencyExchange2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party and provides currency exchange info in case the instructed amount and/or currency is/are different from the entry amount and/or currency.
    /// </summary>
    [IsoId("_SVf1xdp-Ed-ak6NoX_4Aeg_1205556020")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails1? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails1? InstructedAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails1? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    [IsoId("_SVf1xtp-Ed-ak6NoX_4Aeg_1205556469")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails1? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails1? TransactionAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails1? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the countervalue amount and provides currency exchange information. Either the counter amount quoted in an FX deal, or the result of the currency information applied to an instructed amount, before deduction of charges.
    /// </summary>
    [IsoId("_SVf1x9p-Ed-ak6NoX_4Aeg_1205556132")]
    [DisplayName("Counter Value Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrValAmt")]
    #endif
    [IsoXmlTag("CntrValAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails1? CounterValueAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails1? CounterValueAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails1? CounterValueAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the amount of money, based on terms of corporate action event and balance of underlying securities, entitled to/from the account owner.||Amount of money, based on terms of corporate action event and balance of underlying securities, entitled to/from the account owner.|In those situations, this amount may alternatively be called entitled amount.
    /// </summary>
    [IsoId("_SVf1yNp-Ed-ak6NoX_4Aeg_1205556080")]
    [DisplayName("Announced Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncdPstngAmt")]
    #endif
    [IsoXmlTag("AnncdPstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails1? AnnouncedPostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails1? AnnouncedPostingAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails1? AnnouncedPostingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides proprietary amount information.
    /// </summary>
    [IsoId("_SVo_sNp-Ed-ak6NoX_4Aeg_1205556409")]
    [DisplayName("Proprietary Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryAmt")]
    #endif
    [IsoXmlTag("PrtryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails2? ProprietaryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails2? ProprietaryAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails2? ProprietaryAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
