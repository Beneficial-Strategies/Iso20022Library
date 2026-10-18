// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction150"/>
[IsoId("_8o7JMTEsEe6GxLzpkVnWYg")]
[DisplayName("Payment Transaction150")]
public partial record PaymentTransaction150
{
    /// <inheritdoc cref="IPaymentTransaction150.AcceptanceDateTime"/>
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.AccountServicerReference"/>
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.ChargesInformation"/>
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction150.ClearingSystemReference"/>
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.DebtorDecisionDateTime"/>
    [DisplayName("Debtor Decision Date Time")]
    [IsoXmlTag("DbtrDcsnDtTm")]
    public IsoISODateTime? DebtorDecisionDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.EnclosedFile"/>
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction150.OriginalEndToEndIdentification"/>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.OriginalInstructionIdentification"/>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.OriginalTransactionReference"/>
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference40? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.OriginalUETR"/>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.PaymentConditionStatus"/>
    [DisplayName("Payment Condition Status")]
    [IsoXmlTag("PmtCondSts")]
    public PaymentConditionStatus2? PaymentConditionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.StatusIdentification"/>
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction150.StatusReasonInformation"/>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation14> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction150.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction150.TransactionStatus"/>
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }
}
