// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction108"/>
[IsoId("_YNljSW49EeiU9cctagi5ow")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction108
{
    /// <inheritdoc cref="IPaymentTransaction108.ReversalIdentification"/>
    [IsoId("_YWrN8W49EeiU9cctagi5ow")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.OriginalInstructionIdentification"/>
    [IsoId("_YWrN8249EeiU9cctagi5ow")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.OriginalEndToEndIdentification"/>
    [IsoId("_YWrN9W49EeiU9cctagi5ow")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.OriginalUETR"/>
    [IsoId("_K6hdMXrfEeidVZmeoasaWQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.OriginalInstructedAmount"/>
    [IsoId("_YWrN9249EeiU9cctagi5ow")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.ReversedInstructedAmount"/>
    [IsoId("_YWrN-W49EeiU9cctagi5ow")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.ChargeBearer"/>
    [IsoId("_YWrN-249EeiU9cctagi5ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.ReversalReasonInformation"/>
    [IsoId("_YWrN_W49EeiU9cctagi5ow")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason9> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction108.OriginalTransactionReference"/>
    [IsoId("_YWrN_249EeiU9cctagi5ow")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference28? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction108.SupplementaryData"/>
    [IsoId("_YWrOAW49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
