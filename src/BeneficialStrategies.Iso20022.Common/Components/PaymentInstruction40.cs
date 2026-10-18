// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction40"/>
[IsoId("_e0lYYdcZEeqRFcf2R4bPBw")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction40
{
    /// <inheritdoc cref="IPaymentInstruction40.PaymentInformationIdentification"/>
    [IsoId("_e15nI9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.PaymentMethod"/>
    [IsoId("_e15nJdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.RequestedAdviceType"/>
    [IsoId("_e15nJ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.BatchBooking"/>
    [IsoId("_e15nKdcZEeqRFcf2R4bPBw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.NumberOfTransactions"/>
    [IsoId("_e15nK9cZEeqRFcf2R4bPBw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.ControlSum"/>
    [IsoId("_e15nLdcZEeqRFcf2R4bPBw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.PaymentTypeInformation"/>
    [IsoId("_e15nL9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.RequestedExecutionDate"/>
    [IsoId("_e15nMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.PoolingAdjustmentDate"/>
    [IsoId("_e15nM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.Debtor"/>
    [IsoId("_e15nNdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.DebtorAccount"/>
    [IsoId("_e15nN9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.DebtorAgent"/>
    [IsoId("_e15nOdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.DebtorAgentAccount"/>
    [IsoId("_e15nO9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.InstructionForDebtorAgent"/>
    [IsoId("_e15nPdcZEeqRFcf2R4bPBw")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.UltimateDebtor"/>
    [IsoId("_e15nP9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.ChargeBearer"/>
    [IsoId("_e15nQdcZEeqRFcf2R4bPBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.ChargesAccount"/>
    [IsoId("_e15nQ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount40? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.ChargesAccountAgent"/>
    [IsoId("_e15nRdcZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction40.CreditTransferTransactionInformation"/>
    [IsoId("_e15nR9cZEeqRFcf2R4bPBw")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction54> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _e15nR9cZEeqRFcf2R4bPBw
}
