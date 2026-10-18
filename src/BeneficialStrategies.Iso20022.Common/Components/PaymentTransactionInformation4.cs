// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation4"/>
[IsoId("_Pr6kbtp-Ed-ak6NoX_4Aeg_2146802204")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation4
{
    /// <inheritdoc cref="IPaymentTransactionInformation4.ReversalIdentification"/>
    [IsoId("_PsEVYNp-Ed-ak6NoX_4Aeg_2146802222")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.OriginalPaymentInformationIdentification"/>
    [IsoId("_PsEVYdp-Ed-ak6NoX_4Aeg_2146802256")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.OriginalInstructionIdentification"/>
    [IsoId("_PsEVYtp-Ed-ak6NoX_4Aeg_2146802516")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.OriginalEndToEndIdentification"/>
    [IsoId("_PsEVY9p-Ed-ak6NoX_4Aeg_2146802533")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.OriginalInstructedAmount"/>
    [IsoId("_PsEVZNp-Ed-ak6NoX_4Aeg_1381325256")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public CurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.ReversedInstructedAmount"/>
    [IsoId("_PsEVZdp-Ed-ak6NoX_4Aeg_2146802593")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public CurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.ChargeBearer"/>
    [IsoId("_PsEVZtp-Ed-ak6NoX_4Aeg_-2147244601")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation4.ReversalReasonInformation"/>
    [IsoId("_PsEVZ9p-Ed-ak6NoX_4Aeg_-2147244463")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<ReversalReasonInformation1> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation4.OriginalTransactionReference"/>
    [IsoId("_PsEVaNp-Ed-ak6NoX_4Aeg_-2147244048")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; }
}
