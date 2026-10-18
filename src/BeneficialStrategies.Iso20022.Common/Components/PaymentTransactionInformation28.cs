// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation28"/>
[IsoId("_P2DX2dp-Ed-ak6NoX_4Aeg_890765236")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation28
{
    /// <inheritdoc cref="IPaymentTransactionInformation28.ReversalIdentification"/>
    [IsoId("_P2DX2tp-Ed-ak6NoX_4Aeg_890765267")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation28.OriginalInstructionIdentification"/>
    [IsoId("_P2DX29p-Ed-ak6NoX_4Aeg_890765328")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation28.OriginalEndToEndIdentification"/>
    [IsoId("_P2DX3Np-Ed-ak6NoX_4Aeg_890765351")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation28.OriginalInstructedAmount"/>
    [IsoId("_P2MhwNp-Ed-ak6NoX_4Aeg_890765660")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation28.ReversedInstructedAmount"/>
    [IsoId("_P2Mhwdp-Ed-ak6NoX_4Aeg_890765599")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation28.ChargeBearer"/>
    [IsoId("_P2Mhwtp-Ed-ak6NoX_4Aeg_890765630")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation28.ReversalReasonInformation"/>
    [IsoId("_P2Mhw9p-Ed-ak6NoX_4Aeg_890765705")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<ReversalReasonInformation6> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation28.OriginalTransactionReference"/>
    [IsoId("_P2MhxNp-Ed-ak6NoX_4Aeg_891685732")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
