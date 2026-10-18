// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction87"/>
[IsoId("_llmuYYmdEeeKR__nUfxjwA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction87
{
    /// <inheritdoc cref="IPaymentTransaction87.ReturnIdentification"/>
    [IsoId("_ltpQGYmdEeeKR__nUfxjwA")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalGroupInformation"/>
    [IsoId("_ltpQG4mdEeeKR__nUfxjwA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalInstructionIdentification"/>
    [IsoId("_ltpQHYmdEeeKR__nUfxjwA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalEndToEndIdentification"/>
    [IsoId("_ltpQH4mdEeeKR__nUfxjwA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalTransactionIdentification"/>
    [IsoId("_ltpQIYmdEeeKR__nUfxjwA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalClearingSystemReference"/>
    [IsoId("_ltpQI4mdEeeKR__nUfxjwA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalInterbankSettlementAmount"/>
    [IsoId("_ltpQJYmdEeeKR__nUfxjwA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.OriginalInterbankSettlementDate"/>
    [IsoId("_6XaXIYmiEeeKR__nUfxjwA")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ReturnedInterbankSettlementAmount"/>
    [IsoId("_ltpQJ4mdEeeKR__nUfxjwA")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.InterbankSettlementDate"/>
    [IsoId("_ltpQKYmdEeeKR__nUfxjwA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.SettlementPriority"/>
    [IsoId("_ltpQK4mdEeeKR__nUfxjwA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ReturnedInstructedAmount"/>
    [IsoId("_ltpQLYmdEeeKR__nUfxjwA")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ExchangeRate"/>
    [IsoId("_ltpQL4mdEeeKR__nUfxjwA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.CompensationAmount"/>
    [IsoId("_ltpQMYmdEeeKR__nUfxjwA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ChargeBearer"/>
    [IsoId("_ltpQM4mdEeeKR__nUfxjwA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ChargesInformation"/>
    [IsoId("_ltpQNYmdEeeKR__nUfxjwA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction87.ClearingSystemReference"/>
    [IsoId("_qPwhoYmjEeeKR__nUfxjwA")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.InstructingAgent"/>
    [IsoId("_ltpQN4mdEeeKR__nUfxjwA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.InstructedAgent"/>
    [IsoId("_ltpQOYmdEeeKR__nUfxjwA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ReturnChain"/>
    [IsoId("_0lWEIImdEeeKR__nUfxjwA")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    public TransactionParties5? ReturnChain { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.ReturnReasonInformation"/>
    [IsoId("_ltpQO4mdEeeKR__nUfxjwA")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason4> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction87.OriginalTransactionReference"/>
    [IsoId("_ltpQPYmdEeeKR__nUfxjwA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction87.SupplementaryData"/>
    [IsoId("_ltpQP4mdEeeKR__nUfxjwA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
