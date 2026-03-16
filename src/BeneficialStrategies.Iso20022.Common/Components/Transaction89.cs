// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_uGVb8abXEeiva6IOmhpVHw")]
[DisplayName("Transaction")]
public record Transaction89
{
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_uRyeC6bXEeiva6IOmhpVHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MessageReason { get; init; }

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_uRyeDabXEeiva6IOmhpVHw")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_uRyeE6bXEeiva6IOmhpVHw")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_uRyeFabXEeiva6IOmhpVHw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification11 TransactionIdentification { get; init; }

    /// <summary>
    /// Issuer provides a reference for the dispute.
    /// </summary>
    [IsoId("_wG1MsabaEeiva6IOmhpVHw")]
    [DisplayName("Dispute Reference")]
    [IsoXmlTag("DsptRef")]
    public DisputeReference1? DisputeReference { get; init; }

    /// <summary>
    /// Fulfilment request instructions for the retrieval.
    /// </summary>
    [IsoId("_3EYDEabZEeiva6IOmhpVHw")]
    [DisplayName("Retrieval Fulfilment Instructions")]
    [IsoXmlTag("RtrvlFlfmtInstrs")]
    public RetrievalFulfilmentInstructions1? RetrievalFulfilmentInstructions { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_uRyeHabXEeiva6IOmhpVHw")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_uRyeKabXEeiva6IOmhpVHw")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_umAQ4RqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
