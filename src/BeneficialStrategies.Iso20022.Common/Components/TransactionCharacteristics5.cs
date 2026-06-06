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
[IsoId("_fUSlgR7aEfCkq6-p7S3J1Q")]
[DisplayName("Transaction Characteristics5")]
public record TransactionCharacteristics5
{
    /// <summary>
    /// Code that indicates the type of transaction being undertaken in accordance with ISO 8583, Transaction Type.
    /// </summary>
    [IsoId("_fbZ6IR7aEfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_fbZ6KR7aEfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Attribute of the transaction. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_fbZ6Kx7aEfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public SimpleValueList<TransactionAttribute3Code> TransactionAttribute { get; init; } = [];

    /// <summary>
    /// Indicates the previous message is cancelled.
    /// </summary>
    [IsoId("_fbZ6Ox7aEfCkq6-p7S3J1Q")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public IsoTrueFalseIndicator? Cancellation { get; init; }

    /// <summary>
    /// Indicates the finanical message is the collection only, no clearing and settlement required.
    /// </summary>
    [IsoId("_EnQDsWDcEfCoP_h9uwd39Q")]
    [DisplayName("Collection")]
    [IsoXmlTag("Colltn")]
    public IsoTrueFalseIndicator? Collection { get; init; }

    /// <summary>
    /// Indicates the type of transaction that will follow an approved InquiryVerificationResponse or AuthorizationResponse.
    /// </summary>
    [IsoId("_4oOngWP9EfCX7uJiAWHfoQ")]
    [DisplayName("Subsequent Transaction Type")]
    [IsoXmlTag("SbsqntTxTp")]
    public ISO8583TransactionTypeCode? SubsequentTransactionType { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// </summary>
    [IsoId("_fbZ6PR7aEfCkq6-p7S3J1Q")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_fbZ6Sx7aEfCkq6-p7S3J1Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_fbZ6TR7aEfCkq6-p7S3J1Q")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_fbZ6VR7aEfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Indicate which routing table acquirer used to determine the network/program Id. 
    /// </summary>
    [IsoId("_WHJpEGDcEfCoP_h9uwd39Q")]
    [DisplayName("Routing Table Identification")]
    [IsoXmlTag("RtgTblId")]
    public IsoMax35Text? RoutingTableIdentification { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_s2H5YkYXEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_s2H5Y0YXEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_mJgCoV58EfCoP_h9uwd39Q")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData22> LocalData { get; init; } = [];
}
