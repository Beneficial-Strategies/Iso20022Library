// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation29"/>
[IsoId("_P3_Ridp-Ed-ak6NoX_4Aeg_-327433227")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation29
{
    /// <inheritdoc cref="IPaymentTransactionInformation29.ReversalIdentification"/>
    [IsoId("_P4JCgNp-Ed-ak6NoX_4Aeg_-327433196")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.OriginalInstructionIdentification"/>
    [IsoId("_P4JCgdp-Ed-ak6NoX_4Aeg_-327432896")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.OriginalEndToEndIdentification"/>
    [IsoId("_P4JCgtp-Ed-ak6NoX_4Aeg_-327432835")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.OriginalTransactionIdentification"/>
    [IsoId("_P4JCg9p-Ed-ak6NoX_4Aeg_-327432804")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.OriginalClearingSystemReference"/>
    [IsoId("_P4JChNp-Ed-ak6NoX_4Aeg_-1335418230")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.OriginalInterbankSettlementAmount"/>
    [IsoId("_P4JChdp-Ed-ak6NoX_4Aeg_-327432743")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.ReversedInterbankSettlementAmount"/>
    [IsoId("_P4JChtp-Ed-ak6NoX_4Aeg_-327432342")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.InterbankSettlementDate"/>
    [IsoId("_P4JCh9p-Ed-ak6NoX_4Aeg_-327432464")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.ReversedInstructedAmount"/>
    [IsoId("_P4SMcNp-Ed-ak6NoX_4Aeg_-327432311")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.ExchangeRate"/>
    [IsoId("_P4SMcdp-Ed-ak6NoX_4Aeg_-327432403")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.CompensationAmount"/>
    [IsoId("_P4SMctp-Ed-ak6NoX_4Aeg_-327432433")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.ChargeBearer"/>
    [IsoId("_P4SMc9p-Ed-ak6NoX_4Aeg_-327432372")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.ChargesInformation"/>
    [IsoId("_P4SMdNp-Ed-ak6NoX_4Aeg_-327432187")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation29.InstructingAgent"/>
    [IsoId("_P4SMddp-Ed-ak6NoX_4Aeg_-327432218")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.InstructedAgent"/>
    [IsoId("_P4SMdtp-Ed-ak6NoX_4Aeg_-327431909")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation29.ReversalReasonInformation"/>
    [IsoId("_P4SMd9p-Ed-ak6NoX_4Aeg_-327431940")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<ReversalReasonInformation6> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation29.OriginalTransactionReference"/>
    [IsoId("_P4SMeNp-Ed-ak6NoX_4Aeg_-327432265")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
