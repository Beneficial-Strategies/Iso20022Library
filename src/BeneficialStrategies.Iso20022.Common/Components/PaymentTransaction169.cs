// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction169"/>
[IsoId("f7d74e7a-eafe-4b68-be3f-295ba7da1349")]
[DisplayName("Payment Transaction169")]
public partial record PaymentTransaction169
{
    /// <inheritdoc cref="IPaymentTransaction169.StatusIdentification"/>
    [IsoId("a52027ca-d9c7-48b2-8798-6aeb9df40559")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.OriginalInstructionIdentification"/>
    [IsoId("1d111967-94f4-4f61-adfe-924b09c51b70")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.OriginalEndToEndIdentification"/>
    [IsoId("23c2a645-2e5a-4e71-8ce7-08306f99bcdf")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.OriginalUETR"/>
    [IsoId("42556a34-f7a3-43b0-ad9f-95ee5f8933a5")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.TransactionStatus"/>
    [IsoId("edff6a31-1f24-4dd8-a348-160fe95d89c5")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.StatusReasonInformation"/>
    [IsoId("f500a570-44c3-4acc-9eff-8d918360aec4")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation14> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction169.PaymentConditionStatus"/>
    [IsoId("34dccf95-7955-49f4-8dd8-1db690e2663f")]
    [DisplayName("Payment Condition Status")]
    [IsoXmlTag("PmtCondSts")]
    public PaymentConditionStatus2? PaymentConditionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.ChargesInformation"/>
    [IsoId("35d69462-a944-490e-8adf-c9b5cfd549c3")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction169.DebtorDecisionDateTime"/>
    [IsoId("eee4c3af-7e2b-4ce3-9cdf-3bd98c860d5c")]
    [DisplayName("Debtor Decision Date Time")]
    [IsoXmlTag("DbtrDcsnDtTm")]
    public IsoISODateTime? DebtorDecisionDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.AcceptanceDateTime"/>
    [IsoId("c2eb9881-b3f9-47ca-9997-db0c8b6c9a42")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.AccountServicerReference"/>
    [IsoId("6b03dd1d-3de5-467b-bff7-a67cd691cc61")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.ClearingSystemReference"/>
    [IsoId("b6129fca-055d-4641-9aaf-127e9dff09c5")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.OriginalTransactionReference"/>
    [IsoId("c21200ec-f32a-4fcf-b932-ead97fe72055")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference46? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction169.EnclosedFile"/>
    [IsoId("28324a40-3052-4857-ba81-b96391951bd8")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction169.SupplementaryData"/>
    [IsoId("24fa0581-15d9-4493-b271-48e47c0a3728")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
