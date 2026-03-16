// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZtQtgdp-Ed-ak6NoX_4Aeg_1656870064")]
[Description(@"Specifies the reason why the instruction is in repair.")]
[DerivedFrom(typeof(RepairReasonCode))]
public enum RepairReason2Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/realtime while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZtQtgtp-Ed-ak6NoX_4Aeg_1656870066")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/realtime while only possible to settle in overnight batch."
    )]
    ProcessingBatch = RepairReasonCode.ProcessingBatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZtQtg9p-Ed-ak6NoX_4Aeg_1656870095")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RepairReasonCode.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZtQthNp-Ed-ak6NoX_4Aeg_1656870096")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction = RepairReasonCode.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZtQthdp-Ed-ak6NoX_4Aeg_1656870126")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonCode.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZtQthtp-Ed-ak6NoX_4Aeg_1656870127")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem = RepairReasonCode.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZtQth9p-Ed-ak6NoX_4Aeg_1656870156")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZtQtiNp-Ed-ak6NoX_4Aeg_1656870157")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of settlement.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZtQtidp-Ed-ak6NoX_4Aeg_1656870187")]
    [Description(@"Unrecognised or invalid place of settlement.")]
    PlaceOfSettlement = RepairReasonCode.PlaceOfSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZtaegNp-Ed-ak6NoX_4Aeg_1656870188")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Ztaegdp-Ed-ak6NoX_4Aeg_1656870189")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonCode.Quantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Ztaegtp-Ed-ak6NoX_4Aeg_1656870210")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Ztaeg9p-Ed-ak6NoX_4Aeg_1656870218")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZtaehNp-Ed-ak6NoX_4Aeg_1656870241")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RepairReasonCode.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving or delivering agent.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Ztaehdp-Ed-ak6NoX_4Aeg_1656870249")]
    [Description(@"Unrecognised or invalid receiving or delivering agent.")]
    Agent = RepairReasonCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving or delivering custodian.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Ztaehtp-Ed-ak6NoX_4Aeg_1656870272")]
    [Description(@"Unrecognised or invalid receiving or delivering custodian.")]
    ReceivingOrDeliveringCustodian = RepairReasonCode.ReceivingOrDeliveringCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid buyer or seller.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Ztaeh9p-Ed-ak6NoX_4Aeg_1656870280")]
    [Description(@"Unrecognised or invalid buyer or seller.")]
    BuyerorSeller = RepairReasonCode.BuyerorSeller, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ZtaeiNp-Ed-ak6NoX_4Aeg_1656870281")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonCode.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_Ztaeidp-Ed-ak6NoX_4Aeg_1656870519")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicator = RepairReasonCode.LetterOfGuaranteeIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZtkPgNp-Ed-ak6NoX_4Aeg_1656870520")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RepairReasonCode.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZtkPgdp-Ed-ak6NoX_4Aeg_1656870550")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RepairReasonCode.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZtkPgtp-Ed-ak6NoX_4Aeg_1656870551")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonCode.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZtkPg9p-Ed-ak6NoX_4Aeg_1656870559")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonCode.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZtkPhNp-Ed-ak6NoX_4Aeg_1656870581")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZtkPhdp-Ed-ak6NoX_4Aeg_1656870582")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    Reference = RepairReasonCode.Reference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZtkPhtp-Ed-ak6NoX_4Aeg_1656870611")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RepairReasonCode.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZtkPh9p-Ed-ak6NoX_4Aeg_1656870612")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RepairReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ZtkPiNp-Ed-ak6NoX_4Aeg_1656870642")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RepairReasonCode.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ZtkPidp-Ed-ak6NoX_4Aeg_1656870643")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RepairReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ZtkPitp-Ed-ak6NoX_4Aeg_1656870672")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RepairReasonCode.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZttZcNp-Ed-ak6NoX_4Aeg_1656870673")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed =
        RepairReasonCode.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZttZcdp-Ed-ak6NoX_4Aeg_1656870674")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZttZctp-Ed-ak6NoX_4Aeg_1656870951")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ZttZc9p-Ed-ak6NoX_4Aeg_1656870952")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZttZdNp-Ed-ak6NoX_4Aeg_1656870982")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime = RepairReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZttZddp-Ed-ak6NoX_4Aeg_1656870983")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZttZdtp-Ed-ak6NoX_4Aeg_1656871012")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport = RepairReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZttZd9p-Ed-ak6NoX_4Aeg_1656871013")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = RepairReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ZttZeNp-Ed-ak6NoX_4Aeg_1656871014")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRepair = RepairReasonCode.TypeOfOrderRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_ZttZedp-Ed-ak6NoX_4Aeg_1656871043")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRepair = RepairReasonCode.CommercializationContractRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_Zt3KcNp-Ed-ak6NoX_4Aeg_1656871044")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRepair = RepairReasonCode.FeeCommissionRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid service level agreement preagreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_Zt3Kcdp-Ed-ak6NoX_4Aeg_1656871074")]
    [Description(
        @"Unrecognised or invalid service level agreement preagreed narrative information."
    )]
    NarrativeInformationRepair = RepairReasonCode.NarrativeInformationRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request is in repair since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_Zt3Kctp-Ed-ak6NoX_4Aeg_1656871075")]
    [Description(
        @"Cancellation request is in repair since more than one instruction match to the cancellation criteria."
    )]
    NoMatch = RepairReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request is in repair since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_Zt3Kc9p-Ed-ak6NoX_4Aeg_1656871104")]
    [Description(@"Cancellation request is in repair since the instruction could not be found.")]
    NotFound = RepairReasonCode.NotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message was not recognised. Unknown linked reference.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zt3KdNp-Ed-ak6NoX_4Aeg_1656871105")]
    [Description(@"Message was not recognised. Unknown linked reference.")]
    Unknown = RepairReasonCode.Unknown, // same ordinal as derivation source for type conversions
}
