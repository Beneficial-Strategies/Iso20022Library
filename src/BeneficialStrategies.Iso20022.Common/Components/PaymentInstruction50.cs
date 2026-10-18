// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction50"/>
[IsoId("88833a18-3210-4838-a808-05caac40b3f4")]
[DisplayName("Payment Instruction50")]
public partial record PaymentInstruction50
{
    /// <inheritdoc cref="IPaymentInstruction50.PaymentInformationIdentification"/>
    [IsoId("0db8143c-3f35-43d6-8305-b1ce885687e1")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.PaymentMethod"/>
    [IsoId("6cd09cd3-0f8d-418b-9b16-f63d5502291f")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.RequestedAdviceType"/>
    [IsoId("f073c776-0f5c-4680-9296-acf3a0594cfd")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.BatchBooking"/>
    [IsoId("78735f7e-f6cb-4385-b0be-2d9724c37c17")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.NumberOfTransactions"/>
    [IsoId("e1075d7f-6168-4606-a287-fccef6a4226d")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.ControlSum"/>
    [IsoId("13e9d3b6-e22d-4a4d-b7cc-801a6ef0570f")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.PaymentTypeInformation"/>
    [IsoId("af8624dd-3c3e-422d-8cba-a792851d20db")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.RequestedCollectionDate"/>
    [IsoId("90ab1a25-d3b0-44af-b707-657686a70954")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.Creditor"/>
    [IsoId("063eb865-20b2-478f-a0ad-ec4c8b6887ba")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.CreditorAccount"/>
    [IsoId("cb1718b4-f65a-4e88-a850-4941bd993c78")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount40 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.CreditorAgent"/>
    [IsoId("7f41e68a-0579-47b8-ad66-6e46769a0eb1")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.CreditorAgentAccount"/>
    [IsoId("a1855646-878a-4901-abaf-5dd43b0eef1c")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.UltimateCreditor"/>
    [IsoId("a22d10f9-e87c-4131-8eab-e4c304b0835a")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.ChargeBearer"/>
    [IsoId("ecd3af9a-967e-472f-a37c-d5c0263250b5")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.ChargesAccount"/>
    [IsoId("ec4d49dc-021a-46c6-958e-69b155026144")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount40? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.ChargesAccountAgent"/>
    [IsoId("eb8cb8f0-2de8-438a-a32d-cf706caf5ee2")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.CreditorSchemeIdentification"/>
    [IsoId("fb17a2ee-e600-4efb-9a91-b3d578848aaa")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction50.DirectDebitTransactionInformation"/>
    [IsoId("9f25952d-4690-49c3-a875-7cbd76a528c7")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    [MinLength(1)]
    public ValueList<DirectDebitTransactionInformation34> DirectDebitTransactionInformation { get; init; } = [];
}
