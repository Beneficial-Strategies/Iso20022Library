// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction182"/>
[IsoId("_qAAHgZe-EfCsfrvk22Hpaw")]
[DisplayName("Payment Transaction182")]
public partial record PaymentTransaction182
{
    /// <inheritdoc cref="IPaymentTransaction182.ReversalIdentification"/>
    [IsoId("_qHFm9Ze-EfCsfrvk22Hpaw")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalGroupInformation"/>
    [IsoId("_qHFm95e-EfCsfrvk22Hpaw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalInstructionIdentification"/>
    [IsoId("_qHFm-Ze-EfCsfrvk22Hpaw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalEndToEndIdentification"/>
    [IsoId("_qHFm-5e-EfCsfrvk22Hpaw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalTransactionIdentification"/>
    [IsoId("_qHFm_Ze-EfCsfrvk22Hpaw")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalUETR"/>
    [IsoId("_qHFm_5e-EfCsfrvk22Hpaw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalClearingSystemReference"/>
    [IsoId("_qHFnAZe-EfCsfrvk22Hpaw")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.OriginalInterbankSettlementAmount"/>
    [IsoId("_qHFnA5e-EfCsfrvk22Hpaw")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.ReversedInterbankSettlementAmount"/>
    [IsoId("_qHFnBZe-EfCsfrvk22Hpaw")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.InterbankSettlementDate"/>
    [IsoId("_qHFnB5e-EfCsfrvk22Hpaw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.SettlementPriority"/>
    [IsoId("_qHFnCZe-EfCsfrvk22Hpaw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.SettlementTimeIndication"/>
    [IsoId("_qHFnC5e-EfCsfrvk22Hpaw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.ReversedInstructedAmount"/>
    [IsoId("_qHFnDZe-EfCsfrvk22Hpaw")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.ExchangeRate"/>
    [IsoId("_qHFnD5e-EfCsfrvk22Hpaw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.CompensationAmount"/>
    [IsoId("_qHFnEZe-EfCsfrvk22Hpaw")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.ChargeBearer"/>
    [IsoId("_qHFnE5e-EfCsfrvk22Hpaw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.ChargesInformation"/>
    [IsoId("_qHFnFZe-EfCsfrvk22Hpaw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction182.InstructingAgent"/>
    [IsoId("_qHFnF5e-EfCsfrvk22Hpaw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.InstructedAgent"/>
    [IsoId("_qHFnGZe-EfCsfrvk22Hpaw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.ReversalReasonInformation"/>
    [IsoId("_qHFnG5e-EfCsfrvk22Hpaw")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason10> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction182.OriginalTransactionReference"/>
    [IsoId("_qHFnHZe-EfCsfrvk22Hpaw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference47? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction182.SupplementaryData"/>
    [IsoId("_qHFnH5e-EfCsfrvk22Hpaw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
