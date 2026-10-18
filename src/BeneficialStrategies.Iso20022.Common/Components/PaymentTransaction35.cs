// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction35"/>
[IsoId("_tLARIFkyEeGeoaLUQk__nA_808534549")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction35
{
    /// <inheritdoc cref="IPaymentTransaction35.ReversalIdentification"/>
    [IsoId("_tLJbEFkyEeGeoaLUQk__nA_694695483")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction35.OriginalInstructionIdentification"/>
    [IsoId("_tLJbEVkyEeGeoaLUQk__nA_-302376870")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction35.OriginalEndToEndIdentification"/>
    [IsoId("_tLJbElkyEeGeoaLUQk__nA_-1299449223")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction35.OriginalInstructedAmount"/>
    [IsoId("_tLJbE1kyEeGeoaLUQk__nA_1998445720")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction35.ReversedInstructedAmount"/>
    [IsoId("_tLTMEFkyEeGeoaLUQk__nA_1001373367")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction35.ChargeBearer"/>
    [IsoId("_tLTMEVkyEeGeoaLUQk__nA_4301014")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction35.ReversalReasonInformation"/>
    [IsoId("_tLTMElkyEeGeoaLUQk__nA_-915732638")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction35.OriginalTransactionReference"/>
    [IsoId("_tLTME1kyEeGeoaLUQk__nA_770257264")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }
}
