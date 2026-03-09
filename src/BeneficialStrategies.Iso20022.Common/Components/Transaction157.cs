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
/// Details of transaction for a file action.
/// </summary>
[IsoId("_rqZBIYgpEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction157
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction157 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction157( FileActionDetails2 reqFileActionDetails )
    {
        FileActionDetails = reqFileActionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_aiTBd8sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MessageReason { get; init; } 
    #else
    public string? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_rvxQY4gpEeu8-LhY4KPfWg")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_rvxQZYgpEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification12? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of file action.
    /// </summary>
    [IsoId("_rvxQZ4gpEeu8-LhY4KPfWg")]
    [DisplayName("File Action Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnScp")]
    #endif
    [IsoXmlTag("FileActnScp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FileActionScope1Code? FileActionScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionScope1Code? FileActionScope { get; init; } 
    #else
    public FileActionScope1Code? FileActionScope { get; set; } 
    #endif
    
    /// <summary>
    /// Type of file action.
    /// ISO 8583:87 bit 91
    /// </summary>
    [IsoId("_rvxQaYgpEeu8-LhY4KPfWg")]
    [DisplayName("File Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnTp")]
    #endif
    [IsoXmlTag("FileActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FileActionType2Code? FileActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionType2Code? FileActionType { get; init; } 
    #else
    public FileActionType2Code? FileActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Other file action type in free text.
    /// </summary>
    [IsoId("_rvxQa4gpEeu8-LhY4KPfWg")]
    [DisplayName("Other File Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFileActnTp")]
    #endif
    [IsoXmlTag("OthrFileActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFileActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFileActionType { get; init; } 
    #else
    public System.String? OtherFileActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    [IsoId("_rvxQbYgpEeu8-LhY4KPfWg")]
    [DisplayName("File Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnDtls")]
    #endif
    [IsoXmlTag("FileActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FileActionDetails2 FileActionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FileActionDetails2 FileActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionDetails2 FileActionDetails { get; init; } 
    #else
    public FileActionDetails2 FileActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_rvxQb4gpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_rvxQcYgpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies that this batch or collection is a corrected version of a batch or collection that was previously sent.
    /// </summary>
    [IsoId("_ULdioJb9Eeuc6pwKtqbEVQ")]
    [DisplayName("Correction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crrctn")]
    #endif
    [IsoXmlTag("Crrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorrectionIdentification1? Correction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorrectionIdentification1? Correction { get; init; } 
    #else
    public CorrectionIdentification1? Correction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that batch or collection is not complete.
    /// </summary>
    [IsoId("_V_dP0Zb9Eeuc6pwKtqbEVQ")]
    [DisplayName("Continuation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConttnInd")]
    #endif
    [IsoXmlTag("ConttnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContinuationIndicator { get; init; } 
    #else
    public System.String? ContinuationIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
