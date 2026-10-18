// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction34"/>
[IsoId("_O4kqwcQAEemsic1bQcEtLA")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction34
{
    /// <inheritdoc cref="IPaymentInstruction34.PaymentInformationIdentification"/>
    [IsoId("_PEiqM8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.PaymentMethod"/>
    [IsoId("_PEiqNcQAEemsic1bQcEtLA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.RequestedAdviceType"/>
    [IsoId("_NLiiUQbJEeqF8ePC1fs2Gg")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.BatchBooking"/>
    [IsoId("_PEiqN8QAEemsic1bQcEtLA")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.NumberOfTransactions"/>
    [IsoId("_PEiqOcQAEemsic1bQcEtLA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.ControlSum"/>
    [IsoId("_PEiqO8QAEemsic1bQcEtLA")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.PaymentTypeInformation"/>
    [IsoId("_PEiqPcQAEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.RequestedExecutionDate"/>
    [IsoId("_PEiqP8QAEemsic1bQcEtLA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.PoolingAdjustmentDate"/>
    [IsoId("_PEiqQcQAEemsic1bQcEtLA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.Debtor"/>
    [IsoId("_PEiqQ8QAEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.DebtorAccount"/>
    [IsoId("_PEiqRcQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount38 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.DebtorAgent"/>
    [IsoId("_PEiqR8QAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.DebtorAgentAccount"/>
    [IsoId("_PEiqScQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.InstructionForDebtorAgent"/>
    [IsoId("_PEiqS8QAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.UltimateDebtor"/>
    [IsoId("_PEiqTcQAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.ChargeBearer"/>
    [IsoId("_PEiqT8QAEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.ChargesAccount"/>
    [IsoId("_PEiqUcQAEemsic1bQcEtLA")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount38? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.ChargesAccountAgent"/>
    [IsoId("_PEiqU8QAEemsic1bQcEtLA")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction34.CreditTransferTransactionInformation"/>
    [IsoId("_PEiqVcQAEemsic1bQcEtLA")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction40> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _PEiqVcQAEemsic1bQcEtLA
}
