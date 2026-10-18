// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction7"/>
[IsoId("_sr23AFkyEeGeoaLUQk__nA_788351870")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction7
{
    /// <inheritdoc cref="IPaymentInstruction7.PaymentInformationIdentification"/>
    [IsoId("_sr23AVkyEeGeoaLUQk__nA_815624050")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.PaymentMethod"/>
    [IsoId("_ssAoAFkyEeGeoaLUQk__nA_1342619993")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.BatchBooking"/>
    [IsoId("_ssAoAVkyEeGeoaLUQk__nA_-1287227415")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.NumberOfTransactions"/>
    [IsoId("_ssAoAlkyEeGeoaLUQk__nA_-760231472")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.ControlSum"/>
    [IsoId("_ssAoA1kyEeGeoaLUQk__nA_415136542")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.PaymentTypeInformation"/>
    [IsoId("_ssJx8FkyEeGeoaLUQk__nA_-1757126836")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.RequestedCollectionDate"/>
    [IsoId("_ssJx8VkyEeGeoaLUQk__nA_1451870292")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.Creditor"/>
    [IsoId("_ssJx8lkyEeGeoaLUQk__nA_-2079031306")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.CreditorAccount"/>
    [IsoId("_ssJx81kyEeGeoaLUQk__nA_-2140262317")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount24 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.CreditorAgent"/>
    [IsoId("_ssJx9FkyEeGeoaLUQk__nA_-1815144810")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.CreditorAgentAccount"/>
    [IsoId("_ssTi8FkyEeGeoaLUQk__nA_-1048515731")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.UltimateCreditor"/>
    [IsoId("_ssTi8VkyEeGeoaLUQk__nA_-1059614508")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.ChargeBearer"/>
    [IsoId("_ssTi8lkyEeGeoaLUQk__nA_-2030469097")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.ChargesAccount"/>
    [IsoId("_ssTi81kyEeGeoaLUQk__nA_-1091585272")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.ChargesAccountAgent"/>
    [IsoId("_sscs4FkyEeGeoaLUQk__nA_1193425166")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.CreditorSchemeIdentification"/>
    [IsoId("_sscs4VkyEeGeoaLUQk__nA_635309386")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction7.DirectDebitTransactionInformation"/>
    [IsoId("_sscs4lkyEeGeoaLUQk__nA_-647271213")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation11> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _sscs4lkyEeGeoaLUQk__nA_-647271213
}
