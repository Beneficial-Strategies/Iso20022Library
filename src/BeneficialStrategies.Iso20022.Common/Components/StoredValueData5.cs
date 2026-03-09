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
/// Data related to the stored value card.
/// </summary>
[IsoId("_HScVsU4AEey_VecAUE-C9Q")]
[DisplayName("Stored Value Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StoredValueData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StoredValueData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StoredValueData5( StoredValueTransactionType2Code reqTransactionType )
    {
        TransactionType = reqTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the stored value account load/reload.
    /// </summary>
    [IsoId("_HZbugU4AEey_VecAUE-C9Q")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Provider { get; init; } 
    #else
    public System.String? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// </summary>
    [IsoId("_HZbug04AEey_VecAUE-C9Q")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StoredValueTransactionType2Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StoredValueTransactionType2Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueTransactionType2Code TransactionType { get; init; } 
    #else
    public StoredValueTransactionType2Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the stored value account or the stored value card.
    /// </summary>
    [IsoId("_HZbuhU4AEey_VecAUE-C9Q")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueAccount2? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueAccount2? AccountIdentification { get; init; } 
    #else
    public StoredValueAccount2? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [IsoId("_HZbuh04AEey_VecAUE-C9Q")]
    [DisplayName("Original POI Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPOITx")]
    #endif
    [IsoXmlTag("OrgnlPOITx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction120? OriginalPOITransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction120? OriginalPOITransaction { get; init; } 
    #else
    public CardPaymentTransaction120? OriginalPOITransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Product code of item purchased with the transaction.
    /// </summary>
    [IsoId("_HZbuiU4AEey_VecAUE-C9Q")]
    [DisplayName("Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCd")]
    #endif
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCode { get; init; } 
    #else
    public System.String? ProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Standard European Article Number Universal Product Code of item purchased with the transaction.
    /// </summary>
    [IsoId("_HZbui04AEey_VecAUE-C9Q")]
    [DisplayName("EANUPC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EANUPC")]
    #endif
    [IsoXmlTag("EANUPC")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? EANUPC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EANUPC { get; init; } 
    #else
    public System.String? EANUPC { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the item line.
    /// </summary>
    [IsoId("_HZbujU4AEey_VecAUE-C9Q")]
    [DisplayName("Item Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmAmt")]
    #endif
    [IsoXmlTag("ItmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ItemAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the monetary amount.
    /// </summary>
    [IsoId("_HZbuj04AEey_VecAUE-C9Q")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction by the host in charge of the stored value transaction.
    /// </summary>
    [IsoId("_HZbukU4AEey_VecAUE-C9Q")]
    [DisplayName("Host Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstTxId")]
    #endif
    [IsoXmlTag("HstTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? HostTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? HostTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? HostTransactionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
