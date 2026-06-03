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
[IsoId("_59mCwV59EfCoP_h9uwd39Q")]
[DisplayName("Transaction Characteristics6")]
public record TransactionCharacteristics6
{
    [IsoId("_6AVNsV59EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    [IsoId("_6AVNuV59EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    public IsoMax35Text? TransactionSubType { get; init; }

    [IsoId("_6AVNu159EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public SimpleValueList<TransactionAttribute3Code> TransactionAttribute { get; init; } = [];

    [IsoId("_6AVNy159EfCoP_h9uwd39Q")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public IsoTrueFalseIndicator? Cancellation { get; init; }

    [IsoId("_rMT08GP9EfCX7uJiAWHfoQ")]
    [DisplayName("Subsequent Transaction Type")]
    [IsoXmlTag("SbsqntTxTp")]
    public ISO8583TransactionTypeCode? SubsequentTransactionType { get; init; }

    [IsoId("_6AVNzV59EfCoP_h9uwd39Q")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    [IsoId("_6AVN2159EfCoP_h9uwd39Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    [IsoId("_6AVN3V59EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    [IsoId("_9Acvw159EfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_9AcvxF59EfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    [IsoId("_9AcvxV59EfCoP_h9uwd39Q")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData22> LocalData { get; init; } = [];
}
