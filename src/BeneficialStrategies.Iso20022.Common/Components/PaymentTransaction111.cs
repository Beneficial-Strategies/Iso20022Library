// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction111"/>
[IsoId("_JEjVK3L_EeidQ_AAdEzxQA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction111
{
    /// <inheritdoc cref="IPaymentTransaction111.ReversalIdentification"/>
    [IsoId("_JOiXt3L_EeidQ_AAdEzxQA")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalGroupInformation"/>
    [IsoId("_JOiXuXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalInstructionIdentification"/>
    [IsoId("_JOiXu3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalEndToEndIdentification"/>
    [IsoId("_JOiXvXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalTransactionIdentification"/>
    [IsoId("_JOiXv3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalUETR"/>
    [IsoId("_0oEu0XreEeidVZmeoasaWQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalClearingSystemReference"/>
    [IsoId("_JOiXwXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.OriginalInterbankSettlementAmount"/>
    [IsoId("_JOiXw3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.ReversedInterbankSettlementAmount"/>
    [IsoId("_JOiXxXL_EeidQ_AAdEzxQA")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.InterbankSettlementDate"/>
    [IsoId("_JOiXx3L_EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.SettlementPriority"/>
    [IsoId("_JOiXyXL_EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.SettlementTimeIndication"/>
    [IsoId("_FbB6cYjcEei-69PNFxn_Ew")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.ReversedInstructedAmount"/>
    [IsoId("_JOiXy3L_EeidQ_AAdEzxQA")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.ExchangeRate"/>
    [IsoId("_JOiXzXL_EeidQ_AAdEzxQA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.CompensationAmount"/>
    [IsoId("_JOiXz3L_EeidQ_AAdEzxQA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.ChargeBearer"/>
    [IsoId("_JOiX0XL_EeidQ_AAdEzxQA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.ChargesInformation"/>
    [IsoId("_JOiX03L_EeidQ_AAdEzxQA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction111.InstructingAgent"/>
    [IsoId("_JOiX1XL_EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.InstructedAgent"/>
    [IsoId("_JOiX13L_EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.ReversalReasonInformation"/>
    [IsoId("_JOiX2XL_EeidQ_AAdEzxQA")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason9> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction111.OriginalTransactionReference"/>
    [IsoId("_JOiX23L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference28? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction111.SupplementaryData"/>
    [IsoId("_JOiX3XL_EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
