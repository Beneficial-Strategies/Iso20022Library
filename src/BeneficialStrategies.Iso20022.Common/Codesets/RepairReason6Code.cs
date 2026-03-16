// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the securities financing instruction has a repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ixP4oT9qEeCY7potQsO_IA")]
[Description(@"Specifies the reason why the securities financing instruction has a repair status.")]
[DerivedFrom(typeof(RepairReasonV2Code))]
public enum RepairReason6Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ixZClT9qEeCY7potQsO_IA")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatch = RepairReasonV2Code.ProcessingBatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ixZCmT9qEeCY7potQsO_IA")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction = RepairReasonV2Code.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ixZCnT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ixZCoT9qEeCY7potQsO_IA")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem = RepairReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ixZCpT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonV2Code.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ixZCqT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ixZCrT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonV2Code.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ixZCsT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonV2Code.Quantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ixZCtT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonV2Code.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ixZCuT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ixZCvT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonV2Code.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ixZCwT9qEeCY7potQsO_IA")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RepairReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ixZCxT9qEeCY7potQsO_IA")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RepairReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ixZCyT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonV2Code.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ixZCzT9qEeCY7potQsO_IA")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ixZC0T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ixZC1T9qEeCY7potQsO_IA")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    Reference = RepairReasonV2Code.Reference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ixZC2T9qEeCY7potQsO_IA")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed =
        RepairReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ixZC3T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonV2Code.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ixZC4T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonV2Code.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ixZC5T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonV2Code.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ixZC6T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonV2Code.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing Place of Safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ixZC7T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised, invalid or missing Place of Safekeeping.")]
    PlaceOfSafekeeping = RepairReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ixZC8T9qEeCY7potQsO_IA")]
    [Description(@"Required stamp duty information is missing.")]
    StampDuty = RepairReasonV2Code.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ixZC9T9qEeCY7potQsO_IA")]
    [Description(@"Other. See Narrative.")]
    Other = RepairReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ixZC-T9qEeCY7potQsO_IA")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3 = RepairReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ixZC_T9qEeCY7potQsO_IA")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1 = RepairReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ixZDAT9qEeCY7potQsO_IA")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository = RepairReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ixZDBT9qEeCY7potQsO_IA")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2 = RepairReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ixZDCT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RepairReasonV2Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ixZDDT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RepairReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ixZDET9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RepairReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ixZDFT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RepairReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ixZDGT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport = RepairReasonV2Code.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ixZDHT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RepairReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ixZDIT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RepairReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ixZDJT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime = RepairReasonV2Code.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ixZDKT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RepairReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_q1_VsWtdEeCY4-KZ9JEyUQ_92472732")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = RepairReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_q1_VsmtdEeCY4-KZ9JEyUQ_1934269726")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRepair = RepairReasonV2Code.TypeOfOrderRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_q1_Vs2tdEeCY4-KZ9JEyUQ_753035981")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRepair = RepairReasonV2Code.CommercializationContractRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_q1_VtGtdEeCY4-KZ9JEyUQ_1766970131")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRepair = RepairReasonV2Code.FeeCommissionRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_q1_VtWtdEeCY4-KZ9JEyUQ_838136585")]
    [Description(
        @"Unrecognised or invalid service level agreement pre-agreed narrative information."
    )]
    NarrativeInformationRepair = RepairReasonV2Code.NarrativeInformationRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request is in repair since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_q2JGsGtdEeCY4-KZ9JEyUQ_1412835247")]
    [Description(
        @"Cancellation request is in repair since more than one instruction match to the cancellation criteria."
    )]
    NoMatch = RepairReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request is in repair since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_q2JGsWtdEeCY4-KZ9JEyUQ_892857611")]
    [Description(@"Cancellation request is in repair since the instruction could not be found.")]
    NotFound = RepairReasonV2Code.NotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message was not recognised. Unknown linked reference.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_q2JGsmtdEeCY4-KZ9JEyUQ_-1505593503")]
    [Description(@"Message was not recognised. Unknown linked reference.")]
    Unknown = RepairReasonV2Code.Unknown, // same ordinal as derivation source for type conversions
}
