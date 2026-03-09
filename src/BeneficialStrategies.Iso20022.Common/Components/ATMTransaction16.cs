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
/// Response to the deposit request.
/// </summary>
[IsoId("_0Rvq4a4HEeWL1uap3dNhCQ")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction16( TransactionIdentifier1 reqTransactionIdentification,AmountAndCurrency1 reqTotalAuthorisedAmount )
    {
        TransactionIdentification = reqTransactionIdentification;
        TotalAuthorisedAmount = reqTotalAuthorisedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_0cneIa4HEeWL1uap3dNhCQ")]
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
    [IsoId("_0cneI64HEeWL1uap3dNhCQ")]
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
    /// True if a completion advice has to be sent after the end of the transaction.
    /// </summary>
    [IsoId("_Aq-RYK4IEeWL1uap3dNhCQ")]
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
    [IsoId("_0cneJa4HEeWL1uap3dNhCQ")]
    [DisplayName("Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctData")]
    #endif
    [IsoXmlTag("AcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount10? AccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount10? AccountData { get; init; } 
    #else
    public CardAccount10? AccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_0cneJ64HEeWL1uap3dNhCQ")]
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
    /// Total authorised amount of the deposit transaction.
    /// </summary>
    [IsoId("_0cneKa4HEeWL1uap3dNhCQ")]
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
    [IsoId("_ulFNkK4IEeWL1uap3dNhCQ")]
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
    /// Detail of the requested amounts for the deposit transaction.
    /// </summary>
    [IsoId("_0cneK64HEeWL1uap3dNhCQ")]
    [DisplayName("Detailed Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldReqdAmt")]
    #endif
    [IsoXmlTag("DtldReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 
    #else
    public DetailedAmount16? DetailedRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_59U4MK4IEeWL1uap3dNhCQ")]
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
    /// Outcome of the deposit authorisation.
    /// </summary>
    [IsoId("__BUWgK4IEeWL1uap3dNhCQ")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult13? AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_0cneMa4HEeWL1uap3dNhCQ")]
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
    [IsoId("_EbeSEK4JEeWL1uap3dNhCQ")]
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
