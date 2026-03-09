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
/// Inquiry information for the transaction.
/// </summary>
[IsoId("_TkpPMfyuEeWVMqALyuondw")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction29( TransactionIdentifier1 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_TypO8fyuEeWVMqALyuondw")]
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
    /// Unprotected account information.
    /// </summary>
    [IsoId("_TypO8_yuEeWVMqALyuondw")]
    [DisplayName("Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctData")]
    #endif
    [IsoXmlTag("AcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount7? AccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount7? AccountData { get; init; } 
    #else
    public CardAccount7? AccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_TypO9fyuEeWVMqALyuondw")]
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
    /// Amount to be authorised by the issuer.
    /// </summary>
    [IsoId("_TypO9_yuEeWVMqALyuondw")]
    [DisplayName("Total Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlReqdAmt")]
    #endif
    [IsoXmlTag("TtlReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrency1? TotalRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrency1? TotalRequestedAmount { get; init; } 
    #else
    public AmountAndCurrency1? TotalRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the withdrawal transaction.
    /// </summary>
    [IsoId("_TypO-fyuEeWVMqALyuondw")]
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
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_TypO-_yuEeWVMqALyuondw")]
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
