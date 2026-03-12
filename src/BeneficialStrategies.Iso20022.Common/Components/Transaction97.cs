// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_gfNI4VBQEeedyPuM0kK2EQ")]
[DisplayName("Transaction")]
public partial record Transaction97
{
    #nullable enable
    
    /// <summary>
    /// Reason for sending the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_r8gBWUQhEeiO2efj8UFv0A")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MessageReason { get; init; } 
    
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    [IsoId("_Yv04UIUgEeiERvym7bJ-Ew")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_r8gBVkQhEeiO2efj8UFv0A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Transaction amounts.
    /// </summary>
    [IsoId("_r8gBV0QhEeiO2efj8UFv0A")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts1 TransactionAmounts { get; init; } 
    
    /// <summary>
    /// Data related to the dispute.
    /// </summary>
    [IsoId("_r8gBWEQhEeiO2efj8UFv0A")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public required DisputeData1 DisputeData { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_q8EXsfF7EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; } 
    
    /// <summary>
    /// Additional information related to the chargeback.
    /// </summary>
    [IsoId("_r8gBW0QhEeiO2efj8UFv0A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_utsCsRqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
