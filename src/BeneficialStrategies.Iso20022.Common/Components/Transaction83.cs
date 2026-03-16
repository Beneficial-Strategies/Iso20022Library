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
[IsoId("_Yhis0d-tEeelLeeCyrjnCQ")]
[DisplayName("Transaction")]
public record Transaction83
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_Ys_u4d-tEeelLeeCyrjnCQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText TransactionType { get; init; }

    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_Or-EkRqkEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_Ys_u5d-tEeelLeeCyrjnCQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public AdditionalService1? AdditionalService { get; init; }

    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_eSOCYZ8VEeiia5TML2ovWw")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute1Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_jj-P4Z8VEeiia5TML2ovWw")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// </summary>
    [IsoId("_Ys_u7d-tEeelLeeCyrjnCQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public MessageReason2Code? MessageReason { get; init; }

    /// <summary>
    /// Supports message reason codes that are not defined  in external code list.
    /// </summary>
    [IsoId("_Ys_u79-tEeelLeeCyrjnCQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_Ys_u89-tEeelLeeCyrjnCQ")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Ys_u9d-tEeelLeeCyrjnCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification11 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_tonyEf-0EeiIQOwg4ol7gQ")]
    [DisplayName("Transaction Currency")]
    [IsoXmlTag("TxCcy")]
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; }

    /// <summary>
    /// Further details of some or all amounts in the transaction amount.
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent.
    /// </summary>
    [IsoId("_NgRYUa0wEeiBP5PZ97xcEA")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount20? DetailedAmount { get; init; }

    /// <summary>
    /// Amount used for reconciliation.
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field
    /// </summary>
    [IsoId("_3TaNMa0yEeiBP5PZ97xcEA")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount4? ReconciliationAmount { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_i_Q4Ma0qEeiBP5PZ97xcEA")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public AdditionalAmounts2? AdditionalAmounts { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_N_ubURcNEeit0dtP9bTmEg")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; }

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_Ys_u-9-tEeelLeeCyrjnCQ")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService1? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_Ys_u_d-tEeelLeeCyrjnCQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails2? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_Ys_u_9-tEeelLeeCyrjnCQ")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails2? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_Ys_vBd-tEeelLeeCyrjnCQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_AYUt4RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
