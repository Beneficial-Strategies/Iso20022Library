// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction30"/>
[IsoId("_NvhB9W49EeiU9cctagi5ow")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction30
{
    /// <inheritdoc cref="IPaymentInstruction30.PaymentInformationIdentification"/>
    [IsoId("_N5NJhW49EeiU9cctagi5ow")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.PaymentMethod"/>
    [IsoId("_N5NJh249EeiU9cctagi5ow")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.BatchBooking"/>
    [IsoId("_N5NJiW49EeiU9cctagi5ow")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.NumberOfTransactions"/>
    [IsoId("_N5NJi249EeiU9cctagi5ow")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.ControlSum"/>
    [IsoId("_N5NJjW49EeiU9cctagi5ow")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.PaymentTypeInformation"/>
    [IsoId("_N5NJj249EeiU9cctagi5ow")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.RequestedExecutionDate"/>
    [IsoId("_N5NJkW49EeiU9cctagi5ow")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.PoolingAdjustmentDate"/>
    [IsoId("_N5NJk249EeiU9cctagi5ow")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.Debtor"/>
    [IsoId("_N5NJlW49EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.DebtorAccount"/>
    [IsoId("_N5NJl249EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount38 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.DebtorAgent"/>
    [IsoId("_N5NJmW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.DebtorAgentAccount"/>
    [IsoId("_N5NJm249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.InstructionForDebtorAgent"/>
    [IsoId("_N5NJnW49EeiU9cctagi5ow")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.UltimateDebtor"/>
    [IsoId("_N5NJn249EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.ChargeBearer"/>
    [IsoId("_N5NJoW49EeiU9cctagi5ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.ChargesAccount"/>
    [IsoId("_N5NJo249EeiU9cctagi5ow")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount38? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.ChargesAccountAgent"/>
    [IsoId("_N5NJpW49EeiU9cctagi5ow")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction30.CreditTransferTransactionInformation"/>
    [IsoId("_N5NJp249EeiU9cctagi5ow")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction34> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _N5NJp249EeiU9cctagi5ow
}
