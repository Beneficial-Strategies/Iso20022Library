// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction149.
/// </summary>
[IsoId("_8JUcETEsEe6GxLzpkVnWYg")]
[DisplayName("Payment Transaction149")]
public record PaymentTransaction149
{
    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Charges Information.
    /// </summary>
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Compensation Amount.
    /// </summary>
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Instructed Agent.
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <summary>
    /// Instructing Agent.
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Original Clearing System Reference.
    /// </summary>
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Original Instruction Identification.
    /// </summary>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Original Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Original Transaction Identification.
    /// </summary>
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Original Transaction Reference.
    /// </summary>
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference42? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Original UETR.
    /// </summary>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Reversal Identification.
    /// </summary>
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <summary>
    /// Reversal Reason Information.
    /// </summary>
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason10> ReversalReasonInformation { get; init; } = [];

    /// <summary>
    /// Reversed Instructed Amount.
    /// </summary>
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <summary>
    /// Reversed Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Settlement Priority.
    /// </summary>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Settlement Time Indication.
    /// </summary>
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
