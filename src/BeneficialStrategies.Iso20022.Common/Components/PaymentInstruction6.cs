// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction6"/>
[IsoId("_so30dlkyEeGeoaLUQk__nA_1534787075")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction6
{
    /// <inheritdoc cref="IPaymentInstruction6.PaymentInformationIdentification"/>
    [IsoId("_spBlcFkyEeGeoaLUQk__nA_-1554984035")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.PaymentMethod"/>
    [IsoId("_spBlcVkyEeGeoaLUQk__nA_-660174249")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.BatchBooking"/>
    [IsoId("_spBlclkyEeGeoaLUQk__nA_101009836")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.NumberOfTransactions"/>
    [IsoId("_spBlc1kyEeGeoaLUQk__nA_-23928007")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.ControlSum"/>
    [IsoId("_spLWcFkyEeGeoaLUQk__nA_898235303")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.PaymentTypeInformation"/>
    [IsoId("_spLWcVkyEeGeoaLUQk__nA_942442577")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.RequestedExecutionDate"/>
    [IsoId("_spLWclkyEeGeoaLUQk__nA_-1601601609")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.PoolingAdjustmentDate"/>
    [IsoId("_spLWc1kyEeGeoaLUQk__nA_53894449")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.Debtor"/>
    [IsoId("_spUgYFkyEeGeoaLUQk__nA_-1323856468")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.DebtorAccount"/>
    [IsoId("_spUgYVkyEeGeoaLUQk__nA_-891573212")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.DebtorAgent"/>
    [IsoId("_spUgYlkyEeGeoaLUQk__nA_-1962646245")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.DebtorAgentAccount"/>
    [IsoId("_speRYFkyEeGeoaLUQk__nA_-921919030")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.InstructionForDebtorAgent"/>
    [IsoId("_speRYVkyEeGeoaLUQk__nA_-2047990082")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.UltimateDebtor"/>
    [IsoId("_speRYlkyEeGeoaLUQk__nA_-496044594")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.ChargeBearer"/>
    [IsoId("_speRY1kyEeGeoaLUQk__nA_-1609857717")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.ChargesAccount"/>
    [IsoId("_speRZFkyEeGeoaLUQk__nA_842172616")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.ChargesAccountAgent"/>
    [IsoId("_spoCYFkyEeGeoaLUQk__nA_-1041086864")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction6.CreditTransferTransactionInformation"/>
    [IsoId("_spoCYVkyEeGeoaLUQk__nA_1890849661")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransaction1> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _spoCYVkyEeGeoaLUQk__nA_1890849661
}
