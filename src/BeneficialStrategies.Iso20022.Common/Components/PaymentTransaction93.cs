// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction93"/>
[IsoId("_w1Yg6bPfEeeppqgHuc69jg")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction93
{
    /// <inheritdoc cref="IPaymentTransaction93.ReversalIdentification"/>
    [IsoId("_xDhDkbPfEeeppqgHuc69jg")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.OriginalInstructionIdentification"/>
    [IsoId("_xDhDk7PfEeeppqgHuc69jg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.OriginalEndToEndIdentification"/>
    [IsoId("_xDhDlbPfEeeppqgHuc69jg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.OriginalInstructedAmount"/>
    [IsoId("_xDhDl7PfEeeppqgHuc69jg")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.ReversedInstructedAmount"/>
    [IsoId("_xDhDmbPfEeeppqgHuc69jg")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.ChargeBearer"/>
    [IsoId("_xDhDm7PfEeeppqgHuc69jg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.ReversalReasonInformation"/>
    [IsoId("_xDhDnbPfEeeppqgHuc69jg")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason8> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction93.OriginalTransactionReference"/>
    [IsoId("_xDhDn7PfEeeppqgHuc69jg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction93.SupplementaryData"/>
    [IsoId("_xDhDobPfEeeppqgHuc69jg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
