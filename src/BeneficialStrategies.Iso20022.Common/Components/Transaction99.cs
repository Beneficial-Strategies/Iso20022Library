// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Network management transaction.
/// </summary>
[IsoId("_dPCT0VWOEeeiG_nL4vgKnQ")]
[DisplayName("Transaction")]
public partial record Transaction99
{
    #nullable enable
    
    /// <summary>
    /// Type of network management service.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 70
    /// </summary>
    [IsoId("_dapG4VWOEeeiG_nL4vgKnQ")]
    [DisplayName("Network Management Type")]
    [IsoXmlTag("NtwkMgmtTp")]
    public NetworkManagementType1Code? NetworkManagementType { get; init; } 
    
    /// <summary>
    /// Other type of network management in free text.
    /// </summary>
    [IsoId("_dapG41WOEeeiG_nL4vgKnQ")]
    [DisplayName("Other Network Management Type")]
    [IsoXmlTag("OthrNtwkMgmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherNetworkManagementType { get; init; } 
    
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_AECAMsWbEeiCfKAZkk6ZAQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MessageReason { get; init; } 
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_AECAM8WbEeiCfKAZkk6ZAQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_dapG81WOEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_x3CyQFWREeeiG_nL4vgKnQ")]
    [DisplayName("Number Of Messages")]
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMessages { get; init; } 
    
    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_4b7bkFWREeeiG_nL4vgKnQ")]
    [DisplayName("Maximum Number Of Messages")]
    [IsoXmlTag("MaxNbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumberOfMessages { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_EIWIAvF-EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; } 
    
    /// <summary>
    /// Additional information pertaining to the network management type or function being performed.
    /// </summary>
    [IsoId("_fdnNMQLbEemY3fGHca_J_g")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_mKZWgRqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
