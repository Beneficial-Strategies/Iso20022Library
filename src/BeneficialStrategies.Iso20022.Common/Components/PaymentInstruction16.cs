// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction16"/>
[IsoId("_euj3ER77EeSxevWRRWxNAg")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction16
{
    /// <inheritdoc cref="IPaymentInstruction16.PaymentInformationIdentification"/>
    [IsoId("_e_6s1R77EeSxevWRRWxNAg")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.PaymentMethod"/>
    [IsoId("_e_6s1x77EeSxevWRRWxNAg")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.BatchBooking"/>
    [IsoId("_e_6s2R77EeSxevWRRWxNAg")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.NumberOfTransactions"/>
    [IsoId("_e_6s2x77EeSxevWRRWxNAg")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.ControlSum"/>
    [IsoId("_e_6s3R77EeSxevWRRWxNAg")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.PaymentTypeInformation"/>
    [IsoId("_e_6s3x77EeSxevWRRWxNAg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.RequestedExecutionDate"/>
    [IsoId("_e_6s4R77EeSxevWRRWxNAg")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.PoolingAdjustmentDate"/>
    [IsoId("_e_6s4x77EeSxevWRRWxNAg")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.Debtor"/>
    [IsoId("_e_6s5R77EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.DebtorAccount"/>
    [IsoId("_e_6s5x77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.DebtorAgent"/>
    [IsoId("_e_6s6R77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.DebtorAgentAccount"/>
    [IsoId("_e_6s6x77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.InstructionForDebtorAgent"/>
    [IsoId("_e_6s7R77EeSxevWRRWxNAg")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.UltimateDebtor"/>
    [IsoId("_e_6s7x77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.ChargeBearer"/>
    [IsoId("_e_6s8R77EeSxevWRRWxNAg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.ChargesAccount"/>
    [IsoId("_e_6s8x77EeSxevWRRWxNAg")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.ChargesAccountAgent"/>
    [IsoId("_e_6s9R77EeSxevWRRWxNAg")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction16.CreditTransferTransactionInformation"/>
    [IsoId("_e_6s9x77EeSxevWRRWxNAg")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction20> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _e_6s9x77EeSxevWRRWxNAg
}
