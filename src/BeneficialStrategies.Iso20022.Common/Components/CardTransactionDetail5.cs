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
[IsoId("_L_gNQXu1EeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Detail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionDetail5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionDetail5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionDetail5( CardTransactionAmount5 reqTransactionAmounts )
    {
        TransactionAmounts = reqTransactionAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [IsoId("_ML31UXu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Transaction Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmts")]
    #endif
    [IsoXmlTag("TxAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardTransactionAmount5 TransactionAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardTransactionAmount5 TransactionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionAmount5 TransactionAmounts { get; init; } 
    #else
    public CardTransactionAmount5 TransactionAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    [IsoId("_uuK-kINyEeSXtJ8rlirVJw")]
    [DisplayName("Transaction Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxFees")]
    #endif
    [IsoXmlTag("TxFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount11? TransactionFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount11? TransactionFees { get; init; } 
    #else
    public DetailedAmount11? TransactionFees { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_ML31U3u1EeS2Z_kGi7H1VQ")]
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
    /// Reason to send a card acquirer to issuer message.
    /// It corresponds to ISO 8583, field number 25 for the version 93, and 9 for the version 2003.
    /// </summary>
    [IsoId("_ML31VXu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<MessageReason1Code> MessageReason { get; init; } = new SimpleValueList<MessageReason1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ML31VXu1EeS2Z_kGi7H1VQ
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_ML31Y3u1EeS2Z_kGi7H1VQ")]
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
