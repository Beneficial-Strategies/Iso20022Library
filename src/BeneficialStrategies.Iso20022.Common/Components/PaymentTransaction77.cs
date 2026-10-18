// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction77"/>
[IsoId("_T_zC4WXlEeap-P22vGV91g")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction77
{
    /// <inheritdoc cref="IPaymentTransaction77.ReversalIdentification"/>
    [IsoId("_UKw84WXlEeap-P22vGV91g")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.OriginalInstructionIdentification"/>
    [IsoId("_UKw842XlEeap-P22vGV91g")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.OriginalEndToEndIdentification"/>
    [IsoId("_UKw85WXlEeap-P22vGV91g")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.OriginalInstructedAmount"/>
    [IsoId("_UKw852XlEeap-P22vGV91g")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.ReversedInstructedAmount"/>
    [IsoId("_UKw86WXlEeap-P22vGV91g")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.ChargeBearer"/>
    [IsoId("_UKw862XlEeap-P22vGV91g")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.ReversalReasonInformation"/>
    [IsoId("_UKw87WXlEeap-P22vGV91g")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction77.OriginalTransactionReference"/>
    [IsoId("_UKw872XlEeap-P22vGV91g")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference24? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction77.SupplementaryData"/>
    [IsoId("_UKw88WXlEeap-P22vGV91g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
