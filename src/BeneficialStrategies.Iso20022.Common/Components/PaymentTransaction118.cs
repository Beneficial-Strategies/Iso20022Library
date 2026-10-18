// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction118"/>
[IsoId("_QB1BwcQUEemsic1bQcEtLA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction118
{
    /// <inheritdoc cref="IPaymentTransaction118.ReturnIdentification"/>
    [IsoId("_QPGBucQUEemsic1bQcEtLA")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalGroupInformation"/>
    [IsoId("_QPGBu8QUEemsic1bQcEtLA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalInstructionIdentification"/>
    [IsoId("_QPGBvcQUEemsic1bQcEtLA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalEndToEndIdentification"/>
    [IsoId("_QPGBv8QUEemsic1bQcEtLA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalTransactionIdentification"/>
    [IsoId("_QPGBwcQUEemsic1bQcEtLA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalUETR"/>
    [IsoId("_QPGBw8QUEemsic1bQcEtLA")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalClearingSystemReference"/>
    [IsoId("_QPGBxcQUEemsic1bQcEtLA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalInterbankSettlementAmount"/>
    [IsoId("_QPGBx8QUEemsic1bQcEtLA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.OriginalInterbankSettlementDate"/>
    [IsoId("_QPGBycQUEemsic1bQcEtLA")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ReturnedInterbankSettlementAmount"/>
    [IsoId("_QPGBy8QUEemsic1bQcEtLA")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.InterbankSettlementDate"/>
    [IsoId("_QPGBzcQUEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.SettlementPriority"/>
    [IsoId("_QPGBz8QUEemsic1bQcEtLA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.SettlementTimeIndication"/>
    [IsoId("_QPGB0cQUEemsic1bQcEtLA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ReturnedInstructedAmount"/>
    [IsoId("_QPGB08QUEemsic1bQcEtLA")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ExchangeRate"/>
    [IsoId("_QPGB1cQUEemsic1bQcEtLA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.CompensationAmount"/>
    [IsoId("_QPGB18QUEemsic1bQcEtLA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ChargeBearer"/>
    [IsoId("_QPGB2cQUEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ChargesInformation"/>
    [IsoId("_QPGB28QUEemsic1bQcEtLA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction118.ClearingSystemReference"/>
    [IsoId("_QPGB3cQUEemsic1bQcEtLA")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.InstructingAgent"/>
    [IsoId("_QPGB38QUEemsic1bQcEtLA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.InstructedAgent"/>
    [IsoId("_QPGB4cQUEemsic1bQcEtLA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ReturnChain"/>
    [IsoId("_QPGB48QUEemsic1bQcEtLA")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    public TransactionParties8? ReturnChain { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.ReturnReasonInformation"/>
    [IsoId("_QPGB5cQUEemsic1bQcEtLA")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason6> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction118.OriginalTransactionReference"/>
    [IsoId("_QPGB58QUEemsic1bQcEtLA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference32? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction118.SupplementaryData"/>
    [IsoId("_QPGB6cQUEemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
