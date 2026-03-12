// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of transaction for a file action.
/// </summary>
[IsoId("_rqZBIYgpEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
public partial record Transaction157
{
    #nullable enable
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_aiTBd8sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_rvxQY4gpEeu8-LhY4KPfWg")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_rvxQZYgpEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Scope of file action.
    /// </summary>
    [IsoId("_rvxQZ4gpEeu8-LhY4KPfWg")]
    [DisplayName("File Action Scope")]
    [IsoXmlTag("FileActnScp")]
    public FileActionScope1Code? FileActionScope { get; init; } 
    
    /// <summary>
    /// Type of file action.
    /// ISO 8583:87 bit 91
    /// </summary>
    [IsoId("_rvxQaYgpEeu8-LhY4KPfWg")]
    [DisplayName("File Action Type")]
    [IsoXmlTag("FileActnTp")]
    public FileActionType2Code? FileActionType { get; init; } 
    
    /// <summary>
    /// Other file action type in free text.
    /// </summary>
    [IsoId("_rvxQa4gpEeu8-LhY4KPfWg")]
    [DisplayName("Other File Action Type")]
    [IsoXmlTag("OthrFileActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherFileActionType { get; init; } 
    
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    [IsoId("_rvxQbYgpEeu8-LhY4KPfWg")]
    [DisplayName("File Action Details")]
    [IsoXmlTag("FileActnDtls")]
    public required FileActionDetails2 FileActionDetails { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_rvxQb4gpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_rvxQcYgpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    /// <summary>
    /// Identifies that this batch or collection is a corrected version of a batch or collection that was previously sent.
    /// </summary>
    [IsoId("_ULdioJb9Eeuc6pwKtqbEVQ")]
    [DisplayName("Correction")]
    [IsoXmlTag("Crrctn")]
    public CorrectionIdentification1? Correction { get; init; } 
    
    /// <summary>
    /// Indicates that batch or collection is not complete.
    /// </summary>
    [IsoId("_V_dP0Zb9Eeuc6pwKtqbEVQ")]
    [DisplayName("Continuation Indicator")]
    [IsoXmlTag("ConttnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; } 
    
    
    #nullable disable
    
}
