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
/// Details of the card transaction.
/// </summary>
[IsoId("_p7jWQHsxEeSTS7uHCe8FPQ")]
[DisplayName("Card Transaction Detail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionDetail1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionDetail1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionDetail1( CardTransactionAmount1 reqTransactionAmounts )
    {
        TransactionAmounts = reqTransactionAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amounts of the transaction.
    /// </summary>
    [IsoId("_qU2xoHsyEeSTS7uHCe8FPQ")]
    [DisplayName("Transaction Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmts")]
    #endif
    [IsoXmlTag("TxAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardTransactionAmount1 TransactionAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardTransactionAmount1 TransactionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionAmount1 TransactionAmounts { get; init; } 
    #else
    public CardTransactionAmount1 TransactionAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_N1G2sHs2EeSTS7uHCe8FPQ")]
    [DisplayName("Additional Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmts")]
    #endif
    [IsoXmlTag("AddtlAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount10? AdditionalAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount10? AdditionalAmounts { get; init; } 
    #else
    public DetailedAmount10? AdditionalAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Reason to send an card acquirer to issuer message.
    /// It corresponds to ISO 8583 field number 25 for the version 93, and field number 9 for the version 2003.
    /// </summary>
    [IsoId("_LrwnwHs6EeSTS7uHCe8FPQ")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageReason1Code? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageReason1Code? MessageReason { get; init; } 
    #else
    public MessageReason1Code? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583, field number 57 for the version 93, and 3 for the version 2003.
    /// </summary>
    [IsoId("_jdNqwHs6EeSTS7uHCe8FPQ")]
    [DisplayName("Validity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyDt")]
    #endif
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidityDate { get; init; } 
    #else
    public System.DateOnly? ValidityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_puXfwHs6EeSTS7uHCe8FPQ")]
    [DisplayName("Unattended Level Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UattnddLvlCtgy")]
    #endif
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnattendedLevelCategory { get; init; } 
    #else
    public System.String? UnattendedLevelCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for debits, inquiries and the “from” account for transfers.
    /// </summary>
    [IsoId("_DG-GwHs7EeSTS7uHCe8FPQ")]
    [DisplayName("Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctFr")]
    #endif
    [IsoXmlTag("AcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount1? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount1? AccountFrom { get; init; } 
    #else
    public CardAccount1? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for credits and the “to” account for transfers.
    /// </summary>
    [IsoId("_XMTf4HuUEeSVeNXcmBQ4hQ")]
    [DisplayName("Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTo")]
    #endif
    [IsoXmlTag("AcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount1? AccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount1? AccountTo { get; init; } 
    #else
    public CardAccount1? AccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_ewSr0Hs-EeSTS7uHCe8FPQ")]
    [DisplayName("Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instlmt")]
    #endif
    [IsoXmlTag("Instlmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecurringTransaction2? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecurringTransaction2? Instalment { get; init; } 
    #else
    public RecurringTransaction2? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Information requested against money laundering for a transfer transaction.
    /// </summary>
    [IsoId("_qZh_0Hs-EeSTS7uHCe8FPQ")]
    [DisplayName("Anti Money Laundering")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AML")]
    #endif
    [IsoXmlTag("AML")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AntiMoneyLaundering1? AntiMoneyLaundering { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AntiMoneyLaundering1? AntiMoneyLaundering { get; init; } 
    #else
    public AntiMoneyLaundering1? AntiMoneyLaundering { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_dySVYHuUEeSVeNXcmBQ4hQ")]
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
