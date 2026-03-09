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
/// Deposit transaction for which the service is requested.
/// </summary>
[IsoId("_DGFika4AEeWL1uap3dNhCQ")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction15( TransactionIdentifier1 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_DRHG064AEeWL1uap3dNhCQ")]
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
    [IsoId("_DRHG1a4AEeWL1uap3dNhCQ")]
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
    /// Unprotected account information.
    /// </summary>
    [IsoId("_DRHG164AEeWL1uap3dNhCQ")]
    [DisplayName("Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctData")]
    #endif
    [IsoXmlTag("AcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount9? AccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount9? AccountData { get; init; } 
    #else
    public CardAccount9? AccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_DRHG2a4AEeWL1uap3dNhCQ")]
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
    /// Total amount of the deposit transaction.
    /// </summary>
    [IsoId("_DRHG264AEeWL1uap3dNhCQ")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrency1? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrency1? TotalAmount { get; init; } 
    #else
    public AmountAndCurrency1? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the deposit transaction.
    /// </summary>
    [IsoId("_DRHG3a4AEeWL1uap3dNhCQ")]
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
    /// Deposited media put in the safe.
    /// </summary>
    [IsoId("_f3v6oK4BEeWL1uap3dNhCQ")]
    [DisplayName("Deposited Media")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstdMdia")]
    #endif
    [IsoXmlTag("DpstdMdia")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMDepositedMedia1? DepositedMedia { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMDepositedMedia1? DepositedMedia { get; init; } 
    #else
    public ATMDepositedMedia1? DepositedMedia { get; set; } 
    #endif
    
    /// <summary>
    /// True if a receipt has be requested by the customer.
    /// </summary>
    [IsoId("_DRHG5a4AEeWL1uap3dNhCQ")]
    [DisplayName("Requested Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdRct")]
    #endif
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestedReceipt { get; init; } 
    #else
    public System.String? RequestedReceipt { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_DRHG564AEeWL1uap3dNhCQ")]
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
    
    
    #nullable disable
    
}
