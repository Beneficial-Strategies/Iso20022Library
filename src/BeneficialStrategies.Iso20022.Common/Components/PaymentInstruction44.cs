// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Instruction44.
/// </summary>
[IsoId("_8tPBlzEsEe6GxLzpkVnWYg")]
[DisplayName("Payment Instruction44")]
public record PaymentInstruction44
{
    /// <summary>
    /// Batch Booking.
    /// </summary>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Charges Account.
    /// </summary>
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount40? ChargesAccount { get; init; }

    /// <summary>
    /// Charges Account Agent.
    /// </summary>
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Control Sum.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Credit Transfer Transaction Information.
    /// </summary>
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction61> CreditTransferTransactionInformation { get; init; } =
        [];

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <summary>
    /// Debtor Agent.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <summary>
    /// Debtor Agent Account.
    /// </summary>
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Instruction For Debtor Agent.
    /// </summary>
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <summary>
    /// Number Of Transactions.
    /// </summary>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Payment Information Identification.
    /// </summary>
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Payment Method.
    /// </summary>
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Pooling Adjustment Date.
    /// </summary>
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <summary>
    /// Requested Advice Type.
    /// </summary>
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <summary>
    /// Ultimate Debtor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }
}
