// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction22"/>
[IsoId("_k-FloZRsEeazAtAtDSg0Nw")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction22
{
    /// <inheritdoc cref="IPaymentInstruction22.PaymentInformationIdentification"/>
    [IsoId("_lPZ_I5RsEeazAtAtDSg0Nw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.PaymentMethod"/>
    [IsoId("_lPZ_JZRsEeazAtAtDSg0Nw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.BatchBooking"/>
    [IsoId("_lPZ_J5RsEeazAtAtDSg0Nw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.NumberOfTransactions"/>
    [IsoId("_lPZ_KZRsEeazAtAtDSg0Nw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.ControlSum"/>
    [IsoId("_lPZ_K5RsEeazAtAtDSg0Nw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.PaymentTypeInformation"/>
    [IsoId("_lPZ_LZRsEeazAtAtDSg0Nw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.RequestedExecutionDate"/>
    [IsoId("_lPZ_L5RsEeazAtAtDSg0Nw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTimeChoice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.PoolingAdjustmentDate"/>
    [IsoId("_lPZ_MZRsEeazAtAtDSg0Nw")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.Debtor"/>
    [IsoId("_lPZ_M5RsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.DebtorAccount"/>
    [IsoId("_lPZ_NZRsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.DebtorAgent"/>
    [IsoId("_lPZ_N5RsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.DebtorAgentAccount"/>
    [IsoId("_lPZ_OZRsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.InstructionForDebtorAgent"/>
    [IsoId("_lPZ_O5RsEeazAtAtDSg0Nw")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.UltimateDebtor"/>
    [IsoId("_lPZ_PZRsEeazAtAtDSg0Nw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.ChargeBearer"/>
    [IsoId("_lPZ_P5RsEeazAtAtDSg0Nw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.ChargesAccount"/>
    [IsoId("_lPZ_QZRsEeazAtAtDSg0Nw")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.ChargesAccountAgent"/>
    [IsoId("_lPZ_Q5RsEeazAtAtDSg0Nw")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction22.CreditTransferTransactionInformation"/>
    [IsoId("_lPZ_RZRsEeazAtAtDSg0Nw")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction26> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _lPZ_RZRsEeazAtAtDSg0Nw
}
