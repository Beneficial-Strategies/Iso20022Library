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
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_KsqnwH1DEeCF8NjrBemJWQ_748699006")]
[DisplayName("Acquirer Protocol Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerProtocolParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerProtocolParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerProtocolParameters1( System.String reqProtectCardData )
    {
        ProtectCardData = reqProtectCardData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_KsqnwX1DEeCF8NjrBemJWQ_-1297060321")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification32> AcquirerIdentification { get; init; } = new ValueList<GenericIdentification32>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _KsqnwX1DEeCF8NjrBemJWQ_-1297060321
    
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_Ksqnwn1DEeCF8NjrBemJWQ_-2090866337")]
    [DisplayName("Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplId")]
    #endif
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationIdentification { get; init; } 
    #else
    public System.String? ApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_Ksqnw31DEeCF8NjrBemJWQ_1104861220")]
    [DisplayName("Host")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hst")]
    #endif
    [IsoXmlTag("Hst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerHostConfiguration1? Host { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerHostConfiguration1? Host { get; init; } 
    #else
    public AcquirerHostConfiguration1? Host { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_KsqnxH1DEeCF8NjrBemJWQ_-90176465")]
    [DisplayName("On Line Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineTx")]
    #endif
    [IsoXmlTag("OnLineTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters2? OnLineTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters2? OnLineTransaction { get; init; } 
    #else
    public AcquirerProtocolParameters2? OnLineTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_KsqnxX1DEeCF8NjrBemJWQ_-601084090")]
    [DisplayName("Off Line Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffLineTx")]
    #endif
    [IsoXmlTag("OffLineTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters2? OffLineTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters2? OffLineTransaction { get; init; } 
    #else
    public AcquirerProtocolParameters2? OffLineTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_Ksqnxn1DEeCF8NjrBemJWQ_1405191413")]
    [DisplayName("Reconciliation Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnXchg")]
    #endif
    [IsoXmlTag("RcncltnXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration1? ReconciliationExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration1? ReconciliationExchange { get; init; } 
    #else
    public ExchangeConfiguration1? ReconciliationExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_Ksqnx31DEeCF8NjrBemJWQ_226394548")]
    [DisplayName("Reconciliation By Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnByAcqrr")]
    #endif
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationByAcquirer { get; init; } 
    #else
    public System.String? ReconciliationByAcquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_KsqnyH1DEeCF8NjrBemJWQ_-1958782800")]
    [DisplayName("Totals Per Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlsPerCcy")]
    #endif
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalsPerCurrency { get; init; } 
    #else
    public System.String? TotalsPerCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_KszxsH1DEeCF8NjrBemJWQ_-1428276857")]
    [DisplayName("Batch Transfer Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchTrfCntt")]
    #endif
    [IsoXmlTag("BtchTrfCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchTransactionType1Code? BatchTransferContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchTransactionType1Code? BatchTransferContent { get; init; } 
    #else
    public BatchTransactionType1Code? BatchTransferContent { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_KszxsX1DEeCF8NjrBemJWQ_-717374790")]
    [DisplayName("Message Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgItm")]
    #endif
    [IsoXmlTag("MsgItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageItemCondition1? MessageItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageItemCondition1? MessageItem { get; init; } 
    #else
    public MessageItemCondition1? MessageItem { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_Kszxsn1DEeCF8NjrBemJWQ_1543671091")]
    [DisplayName("Protect Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctCardData")]
    #endif
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProtectCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProtectCardData { get; init; } 
    #else
    public System.String ProtectCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
