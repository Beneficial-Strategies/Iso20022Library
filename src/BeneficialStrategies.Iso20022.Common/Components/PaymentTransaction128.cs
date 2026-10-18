// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction128"/>
[IsoId("_YCkHmQbPEeqF8ePC1fs2Gg")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction128
{
    /// <inheritdoc cref="IPaymentTransaction128.StatusIdentification"/>
    [IsoId("_YOlxUwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.OriginalInstructionIdentification"/>
    [IsoId("_YOlxVQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.OriginalEndToEndIdentification"/>
    [IsoId("_YOlxVwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.OriginalUETR"/>
    [IsoId("_YOlxWQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.TransactionStatus"/>
    [IsoId("_YOlxWwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.StatusReasonInformation"/>
    [IsoId("_YOlxXQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction128.PaymentConditionStatus"/>
    [IsoId("_YOlxXwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Payment Condition Status")]
    [IsoXmlTag("PmtCondSts")]
    public PaymentConditionStatus1? PaymentConditionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.ChargesInformation"/>
    [IsoId("_YOlxYQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction128.DebtorDecisionDateTime"/>
    [IsoId("_YOlxYwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Debtor Decision Date Time")]
    [IsoXmlTag("DbtrDcsnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DebtorDecisionDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.AcceptanceDateTime"/>
    [IsoId("_YOlxZQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.AccountServicerReference"/>
    [IsoId("_YOlxZwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.ClearingSystemReference"/>
    [IsoId("_YOlxaQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.OriginalTransactionReference"/>
    [IsoId("_YOlxawbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference33? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction128.EnclosedFile"/>
    [IsoId("_YOlxbQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction128.SupplementaryData"/>
    [IsoId("_YOlxbwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
