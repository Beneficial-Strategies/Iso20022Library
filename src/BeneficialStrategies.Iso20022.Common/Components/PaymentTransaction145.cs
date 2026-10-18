// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction145"/>
[IsoId("_OTaGxxlWEe2Do_UtrNmb2g")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction145
{
    /// <inheritdoc cref="IPaymentTransaction145.StatusIdentification"/>
    [IsoId("_OdEZARlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.OriginalInstructionIdentification"/>
    [IsoId("_OdEZAxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.OriginalEndToEndIdentification"/>
    [IsoId("_OdEZBRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.OriginalUETR"/>
    [IsoId("_OdEZBxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.TransactionStatus"/>
    [IsoId("_OdEZCRlWEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.StatusReasonInformation"/>
    [IsoId("_OdEZCxlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction145.PaymentConditionStatus"/>
    [IsoId("_OdEZDRlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Condition Status")]
    [IsoXmlTag("PmtCondSts")]
    public PaymentConditionStatus1? PaymentConditionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.ChargesInformation"/>
    [IsoId("_OdEZDxlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges12> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction145.DebtorDecisionDateTime"/>
    [IsoId("_OdEZERlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Decision Date Time")]
    [IsoXmlTag("DbtrDcsnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DebtorDecisionDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.AcceptanceDateTime"/>
    [IsoId("_OdEZExlWEe2Do_UtrNmb2g")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.AccountServicerReference"/>
    [IsoId("_OdEZFRlWEe2Do_UtrNmb2g")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.ClearingSystemReference"/>
    [IsoId("_OdEZFxlWEe2Do_UtrNmb2g")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.OriginalTransactionReference"/>
    [IsoId("_OdEZGRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference38? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction145.EnclosedFile"/>
    [IsoId("_OdEZGxlWEe2Do_UtrNmb2g")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction145.SupplementaryData"/>
    [IsoId("_OdEZHRlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
