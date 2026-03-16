// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement report transaction.
/// </summary>
[IsoId("_bNisUVcyEeeFltjJxERUxw")]
[DisplayName("Transaction")]
public record Transaction104
{
    /// <summary>
    /// Type of settlement report.
    /// </summary>
    [IsoId("_bZXh0VcyEeeFltjJxERUxw")]
    [DisplayName("Settlement Report Type")]
    [IsoXmlTag("SttlmRptTp")]
    public required SettlementReportType1Code SettlementReportType { get; init; }

    /// <summary>
    /// Other type of settlement report in free text.
    /// </summary>
    [IsoId("_bZXh01cyEeeFltjJxERUxw")]
    [DisplayName("Other Settlement Report Type")]
    [IsoXmlTag("OthrSttlmRptTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherSettlementReportType { get; init; }

    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_4TGikmqCEemXfKijhrqa-Q")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<IsoExact4NumericText> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_4TGik2qCEemXfKijhrqa-Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_bZXh41cyEeeFltjJxERUxw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_gVvK0vF-EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Settlement totals of the report.
    /// </summary>
    [IsoId("_bZXh51cyEeeFltjJxERUxw")]
    [DisplayName("Settlement Totals")]
    [IsoXmlTag("SttlmTtls")]
    public SettlementTotals1? SettlementTotals { get; init; }

    /// <summary>
    /// Contains the net funds transfer amount.
    /// </summary>
    [IsoId("_aSyUIGqDEemXfKijhrqa-Q")]
    [DisplayName("Funds Transfer Amount")]
    [IsoXmlTag("FndsTrfAmt")]
    public Amount14? FundsTransferAmount { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_KyMUEWqDEemXfKijhrqa-Q")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_2BLpARqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
