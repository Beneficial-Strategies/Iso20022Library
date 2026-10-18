// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction163.
/// </summary>
[IsoId("_YIoekz3JEe-thIfLZ94a1w")]
public interface IPaymentTransaction163 : IIsoComponent
{
    /// <summary>
    /// Agreed Rate.
    /// </summary>
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    ICurrencyExchange26? AgreedRate { get; }

    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Charges Information.
    /// </summary>
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges16> ChargesInformation { get; }

    /// <summary>
    /// Clearing System Reference.
    /// </summary>
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    IsoMax35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Compensation Amount.
    /// </summary>
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    IsoBaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Instructed Agent.
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }

    /// <summary>
    /// Instructing Agent.
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Original Clearing System Reference.
    /// </summary>
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    IsoMax35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation29? OriginalGroupInformation { get; }

    /// <summary>
    /// Original Instruction Identification.
    /// </summary>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Original Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Original Interbank Settlement Date.
    /// </summary>
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    IsoISODate? OriginalInterbankSettlementDate { get; }

    /// <summary>
    /// Original Transaction Identification.
    /// </summary>
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    IsoMax35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Original Transaction Reference.
    /// </summary>
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference44? OriginalTransactionReference { get; }

    /// <summary>
    /// Original UETR.
    /// </summary>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    IsoUUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Return Chain.
    /// </summary>
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    ITransactionParties11? ReturnChain { get; }

    /// <summary>
    /// Returned Instructed Amount.
    /// </summary>
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; }

    /// <summary>
    /// Returned Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; }

    /// <summary>
    /// Return Identification.
    /// </summary>
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    IsoMax35Text? ReturnIdentification { get; }

    /// <summary>
    /// Return Reason Information.
    /// </summary>
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    IEnumerable<IPaymentReturnReason7> ReturnReasonInformation { get; }

    /// <summary>
    /// Settlement Priority.
    /// </summary>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Settlement Time Indication.
    /// </summary>
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Settlement Time Request.
    /// </summary>
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
