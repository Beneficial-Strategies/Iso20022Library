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
/// Set of elements used to provide information on the original amount.
/// </summary>
[IsoId("_l5QfsQ5rEe2xs7BqO31w6w")]
[DisplayName("Amount And Currency Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndCurrencyExchange4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party and provides currency exchange information in case the instructed amount and/or currency is/are different from the entry amount and/or currency.
    /// </summary>
    [IsoId("_mEI6Aw5rEe2xs7BqO31w6w")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails5? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails5? InstructedAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails5? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    [IsoId("_mEI6BQ5rEe2xs7BqO31w6w")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails5? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails5? TransactionAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails5? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide the countervalue amount and currency exchange information. |Usage: This can be either the counter amount quoted in an FX deal, or the result of the currency information applied to an instructed amount, before deduction of charges.
    /// </summary>
    [IsoId("_mEI6Bw5rEe2xs7BqO31w6w")]
    [DisplayName("Counter Value Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrValAmt")]
    #endif
    [IsoXmlTag("CntrValAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails5? CounterValueAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails5? CounterValueAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails5? CounterValueAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money, based on terms of corporate action event and balance of underlying securities, entitled to/from the account owner.|In some situations, this amount may alternatively be called entitled amount.
    /// </summary>
    [IsoId("_mEI6CQ5rEe2xs7BqO31w6w")]
    [DisplayName("Announced Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncdPstngAmt")]
    #endif
    [IsoXmlTag("AnncdPstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails5? AnnouncedPostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails5? AnnouncedPostingAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails5? AnnouncedPostingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the original amount and currency exchange.
    /// </summary>
    [IsoId("_mEI6Cw5rEe2xs7BqO31w6w")]
    [DisplayName("Proprietary Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryAmt")]
    #endif
    [IsoXmlTag("PrtryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchangeDetails6? ProprietaryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchangeDetails6? ProprietaryAmount { get; init; } 
    #else
    public AmountAndCurrencyExchangeDetails6? ProprietaryAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
