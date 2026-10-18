// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction9"/>
[IsoId("_QQntYSHQEeKGep4bhmamiA")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction9
{
    /// <inheritdoc cref="IPaymentInstruction9.PaymentInformationIdentification"/>
    [IsoId("_QmOKOSHQEeKGep4bhmamiA")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.PaymentMethod"/>
    [IsoId("_QmOKPSHQEeKGep4bhmamiA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.BatchBooking"/>
    [IsoId("_QmOKQSHQEeKGep4bhmamiA")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.NumberOfTransactions"/>
    [IsoId("_QmOKRSHQEeKGep4bhmamiA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.ControlSum"/>
    [IsoId("_QmOKSSHQEeKGep4bhmamiA")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.PaymentTypeInformation"/>
    [IsoId("_QmOKTSHQEeKGep4bhmamiA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.RequestedExecutionDate"/>
    [IsoId("_QmOKVSHQEeKGep4bhmamiA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.PoolingAdjustmentDate"/>
    [IsoId("_QmOKWSHQEeKGep4bhmamiA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.Debtor"/>
    [IsoId("_QmOKXSHQEeKGep4bhmamiA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.DebtorAccount"/>
    [IsoId("_QmOKYSHQEeKGep4bhmamiA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.DebtorAgent"/>
    [IsoId("_QmOKZSHQEeKGep4bhmamiA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.DebtorAgentAccount"/>
    [IsoId("_QmOKaSHQEeKGep4bhmamiA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.InstructionForDebtorAgent"/>
    [IsoId("_QmOKbSHQEeKGep4bhmamiA")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.UltimateDebtor"/>
    [IsoId("_QmOKdSHQEeKGep4bhmamiA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.ChargeBearer"/>
    [IsoId("_QmOKfSHQEeKGep4bhmamiA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.ChargesAccount"/>
    [IsoId("_QmOKhSHQEeKGep4bhmamiA")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.ChargesAccountAgent"/>
    [IsoId("_QmOKiSHQEeKGep4bhmamiA")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction9.CreditTransferTransactionInformation"/>
    [IsoId("_QmOKjSHQEeKGep4bhmamiA")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction6> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _QmOKjSHQEeKGep4bhmamiA
}
