// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key exchange activity transaction.
/// </summary>
[IsoId("_ZtxdcVWXEeeiG_nL4vgKnQ")]
[DisplayName("Transaction")]
public partial record Transaction100
{
    #nullable enable
    
    /// <summary>
    /// Type of key exchange function being performed.
    /// </summary>
    [IsoId("_Z5FVkVWXEeeiG_nL4vgKnQ")]
    [DisplayName("Key Exchange Function")]
    [IsoXmlTag("KeyXchgFctn")]
    public required CardServiceType5Code KeyExchangeFunction { get; init; } 
    
    /// <summary>
    /// Other key exchange function being performed.
    /// </summary>
    [IsoId("_Z5FVk1WXEeeiG_nL4vgKnQ")]
    [DisplayName("Other Key Exchange Function")]
    [IsoXmlTag("OthrKeyXchgFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherKeyExchangeFunction { get; init; } 
    
    /// <summary>
    /// Reason to send a key exchange message.
    /// ISO 8583:1993/2003 bit 25.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_Z5FVmVWXEeeiG_nL4vgKnQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MessageReason { get; init; } 
    
    /// <summary>
    /// Alternate reason to send a message.
    /// </summary>
    [IsoId("_Z5FVm1WXEeeiG_nL4vgKnQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Z5FVl1WXEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Defines the type of key being exchanged.
    /// </summary>
    [IsoId("__lvs8P8aEeic54G0fOJNMg")]
    [DisplayName("Key Exchange Type")]
    [IsoXmlTag("KeyXchgTp")]
    public KeyType1Code? KeyExchangeType { get; init; } 
    
    /// <summary>
    /// Other type of key being exchanged.
    /// </summary>
    [IsoId("_4oO2Uf8cEeic54G0fOJNMg")]
    [DisplayName("Other Key Exchange Type")]
    [IsoXmlTag("OthrKeyXchgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherKeyExchangeType { get; init; } 
    
    /// <summary>
    /// Contains information pertaining to a key exchange. 
    /// ISO 8583 bit 96
    /// </summary>
    [IsoId("_JiNvMf7xEeic54G0fOJNMg")]
    [DisplayName("Key Exchange Data")]
    [IsoXmlTag("KeyXchgData")]
    public KeyExchangeData1? KeyExchangeData { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_55egQvF9EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_dWsFMRqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
