// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation3"/>
[IsoId("_PsOGYNp-Ed-ak6NoX_4Aeg_1422225346")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation3
{
    /// <inheritdoc cref="IPaymentTransactionInformation3.CancellationIdentification"/>
    [IsoId("_PsOGYdp-Ed-ak6NoX_4Aeg_1422225381")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalPaymentInformationIdentification"/>
    [IsoId("_PsOGYtp-Ed-ak6NoX_4Aeg_1422225766")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalInstructionIdentification"/>
    [IsoId("_PsOGY9p-Ed-ak6NoX_4Aeg_1422225801")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalEndToEndIdentification"/>
    [IsoId("_PsOGZNp-Ed-ak6NoX_4Aeg_1422225844")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalTransactionIdentification"/>
    [IsoId("_PsOGZdp-Ed-ak6NoX_4Aeg_1422225879")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalInterbankSettlementAmount"/>
    [IsoId("_PsOGZtp-Ed-ak6NoX_4Aeg_780333300")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalInstructedAmount"/>
    [IsoId("_PsOGZ9p-Ed-ak6NoX_4Aeg_1422225921")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public CurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.InstructingAgent"/>
    [IsoId("_PsOGaNp-Ed-ak6NoX_4Aeg_-472077655")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.InstructedAgent"/>
    [IsoId("_PsXQUNp-Ed-ak6NoX_4Aeg_-472077748")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation3.CancellationReasonInformation"/>
    [IsoId("_PsXQUdp-Ed-ak6NoX_4Aeg_-613481166")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<CancellationReasonInformation1> CancellationReasonInformation { get; init; } =
        [];

    /// <inheritdoc cref="IPaymentTransactionInformation3.OriginalTransactionReference"/>
    [IsoId("_PsXQUtp-Ed-ak6NoX_4Aeg_1422226791")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; }
}
