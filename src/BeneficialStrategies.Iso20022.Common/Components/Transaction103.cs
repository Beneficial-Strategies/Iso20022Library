// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fee transaction type.
/// </summary>
[IsoId("_McaM0VaOEeeFltjJxERUxw")]
[DisplayName("Transaction")]
public record Transaction103
{
    /// <summary>
    /// Type of transaction associated with the main service
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_Ykm2Mq01EeiBP5PZ97xcEA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText TransactionType { get; init; }

    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_scFeYRqkEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:1993/2003 bit 25.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_Mn31-1aOEeeFltjJxERUxw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<IsoExact4NumericText> MessageReason { get; init; } = [];

    /// <summary>
    /// Alternate message reason to send the message.
    /// </summary>
    [IsoId("_Mn31_VaOEeeFltjJxERUxw")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_Mn32AVaOEeeFltjJxERUxw")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Mn32A1aOEeeFltjJxERUxw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification13 TransactionIdentification { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_Mn32B1aOEeeFltjJxERUxw")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts1 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_BfQJ4Rb4Eeit0dtP9bTmEg")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public ValueList<AdditionalAmounts1> AdditionalAmounts { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_v8QyQRcNEeit0dtP9bTmEg")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_IU-bYRqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
