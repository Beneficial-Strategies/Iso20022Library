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
/// Response to the withdrawal transaction request.
/// </summary>
[IsoId("_2Y9Uoa17EeWMg5rOByfExw")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction14( TransactionIdentifier1 reqTransactionIdentification,AmountAndCurrency1 reqTotalAuthorisedAmount,AuthorisationResult13 reqAuthorisationResult )
    {
        TransactionIdentification = reqTransactionIdentification;
        TotalAuthorisedAmount = reqTotalAuthorisedAmount;
        AuthorisationResult = reqAuthorisationResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_2k4Qwa17EeWMg5rOByfExw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_2k4Qw617EeWMg5rOByfExw")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationIdentification { get; init; } 
    #else
    public System.String? ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// True if a withdrawal completion advice has to be sent after the end of the transaction.
    /// </summary>
    [IsoId("_2k4Qxa17EeWMg5rOByfExw")]
    [DisplayName("Completion Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnReqrd")]
    #endif
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CompletionRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CompletionRequired { get; init; } 
    #else
    public System.String? CompletionRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_2k4Qx617EeWMg5rOByfExw")]
    [DisplayName("Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctData")]
    #endif
    [IsoXmlTag("AcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount8? AccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount8? AccountData { get; init; } 
    #else
    public CardAccount8? AccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_2k4Qya17EeWMg5rOByfExw")]
    [DisplayName("Protected Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdAcctData")]
    #endif
    [IsoXmlTag("PrtctdAcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    #else
    public ContentInformationType10? ProtectedAccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    [IsoId("_2k4Qy617EeWMg5rOByfExw")]
    [DisplayName("Total Authorised Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAuthrsdAmt")]
    #endif
    [IsoXmlTag("TtlAuthrsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    #else
    public AmountAndCurrency1 TotalAuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_2k4Qza17EeWMg5rOByfExw")]
    [DisplayName("Total Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlReqdAmt")]
    #endif
    [IsoXmlTag("TtlReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    [IsoId("_2k4Qz617EeWMg5rOByfExw")]
    [DisplayName("Detailed Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldReqdAmt")]
    #endif
    [IsoXmlTag("DtldReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    #else
    public DetailedAmount12? DetailedRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    [IsoId("_2k4Q0a17EeWMg5rOByfExw")]
    [DisplayName("Currency Conversion Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsElgblty")]
    #endif
    [IsoXmlTag("CcyConvsElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion9? CurrencyConversionEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion9? CurrencyConversionEligibility { get; init; } 
    #else
    public CurrencyConversion9? CurrencyConversionEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_2k4Q0617EeWMg5rOByfExw")]
    [DisplayName("Additional Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlChrg")]
    #endif
    [IsoXmlTag("AddtlChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount13? AdditionalCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount13? AdditionalCharge { get; init; } 
    #else
    public DetailedAmount13? AdditionalCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_2k4Q1a17EeWMg5rOByfExw")]
    [DisplayName("Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lmts")]
    #endif
    [IsoXmlTag("Lmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts6? Limits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts6? Limits { get; init; } 
    #else
    public ATMTransactionAmounts6? Limits { get; set; } 
    #endif
    
    /// <summary>
    /// Media mix algorithm requested by the ATM Host, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    [IsoId("_2k4Q1617EeWMg5rOByfExw")]
    [DisplayName("Mix Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MixTp")]
    #endif
    [IsoXmlTag("MixTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MixType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MixType { get; init; } 
    #else
    public System.String? MixType { get; set; } 
    #endif
    
    /// <summary>
    /// Media mix selected requested by the ATM Host.
    /// </summary>
    [IsoId("_2k4Q2a17EeWMg5rOByfExw")]
    [DisplayName("Mix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mix")]
    #endif
    [IsoXmlTag("Mix")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaMix1? Mix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaMix1? Mix { get; init; } 
    #else
    public ATMMediaMix1? Mix { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_2k4Q2617EeWMg5rOByfExw")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorisationResult13 AuthorisationResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorisationResult13 AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult13 AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult13 AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_2k4Q3a17EeWMg5rOByfExw")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ICCRelatedData { get; init; } 
    #else
    public System.Byte[]? ICCRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_2k4Q3617EeWMg5rOByfExw")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand7? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand7? Command { get; init; } 
    #else
    public ATMCommand7? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
