// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstructionInformation2"/>
[IsoId("_PzX3QNp-Ed-ak6NoX_4Aeg_-727808881")]
[DisplayName("Payment Instruction Information")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public partial record PaymentInstructionInformation2
{
    /// <inheritdoc cref="IPaymentInstructionInformation2.PaymentInformationIdentification"/>
    [IsoId("_PzX3Qdp-Ed-ak6NoX_4Aeg_-727807890")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.PaymentMethod"/>
    [IsoId("_PzX3Qtp-Ed-ak6NoX_4Aeg_-727807992")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.PaymentTypeInformation"/>
    [IsoId("_PzX3Q9p-Ed-ak6NoX_4Aeg_-725962274")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation2? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.RequestedCollectionDate"/>
    [IsoId("_PzX3RNp-Ed-ak6NoX_4Aeg_-727808447")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.Creditor"/>
    [IsoId("_PzX3Rdp-Ed-ak6NoX_4Aeg_-695484284")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification8 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.CreditorAccount"/>
    [IsoId("_PzX3Rtp-Ed-ak6NoX_4Aeg_-695483785")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount7 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.CreditorAgent"/>
    [IsoId("_PzX3R9p-Ed-ak6NoX_4Aeg_-695484810")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.CreditorAgentAccount"/>
    [IsoId("_PzX3SNp-Ed-ak6NoX_4Aeg_-695485533")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.UltimateCreditor"/>
    [IsoId("_PzX3Sdp-Ed-ak6NoX_4Aeg_-696408256")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.ChargeBearer"/>
    [IsoId("_PzhBMNp-Ed-ak6NoX_4Aeg_-698253886")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.ChargesAccount"/>
    [IsoId("_PzhBMdp-Ed-ak6NoX_4Aeg_-726884926")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount7? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.ChargesAccountAgent"/>
    [IsoId("_PzhBMtp-Ed-ak6NoX_4Aeg_-726886443")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification3? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation2.DirectDebitTransactionInformation"/>
    [IsoId("_PzhBM9p-Ed-ak6NoX_4Aeg_-726886228")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation1> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _PzhBM9p-Ed-ak6NoX_4Aeg_-726886228
}
