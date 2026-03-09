// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__p30cNojEeC60axPepSq7g_603245162")]
[Description(@"Specifies the reason why the instruction is in repair.")]
[DerivedFrom(typeof(RepairReasonV2Code))]
public enum RepairReason7Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("__p30cdojEeC60axPepSq7g_743377791")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = RepairReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("__p30ctojEeC60axPepSq7g_629538725")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatch = RepairReasonV2Code.ProcessingBatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("__p30c9ojEeC60axPepSq7g_-11372083")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRepair = RepairReasonV2Code.TypeOfOrderRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("__p30dNojEeC60axPepSq7g_-125211149")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RepairReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("__p30ddojEeC60axPepSq7g_749393070")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("__qBlcNojEeC60axPepSq7g_431616409")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem = RepairReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("__qBlcdojEeC60axPepSq7g_317777343")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRepair = RepairReasonV2Code.CommercializationContractRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("__qBlctojEeC60axPepSq7g_-1260563788")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonV2Code.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("__qBlc9ojEeC60axPepSq7g_-1374402854")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("__qBldNojEeC60axPepSq7g_-1271662565")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository = RepairReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("__qBlddojEeC60axPepSq7g_1711409557")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonV2Code.SettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("__qBldtojEeC60axPepSq7g_1597570491")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonV2Code.Quantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("__qKvYNojEeC60axPepSq7g_-1997610713")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonV2Code.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("__qKvYdojEeC60axPepSq7g_-2111449779")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("__qKvYtojEeC60axPepSq7g_918673640")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRepair = RepairReasonV2Code.FeeCommissionRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("__qKvY9ojEeC60axPepSq7g_804834574")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RepairReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("__qKvZNojEeC60axPepSq7g_1243791147")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1 = RepairReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("__qKvZdojEeC60axPepSq7g_-1973155811")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2 = RepairReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("__qUgYNojEeC60axPepSq7g_-2086994877")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3 = RepairReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("__qUgYdojEeC60axPepSq7g_-766165711")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonV2Code.CommonReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("__qUgYtojEeC60axPepSq7g_-880004777")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRepair = RepairReasonV2Code.NarrativeInformationRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("__qUgY9ojEeC60axPepSq7g_311854627")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicator = RepairReasonV2Code.LetterOfGuaranteeIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__qUgZNojEeC60axPepSq7g_198015561")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = RepairReasonV2Code.NarrativeReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("__qUgZdojEeC60axPepSq7g_1072619780")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonV2Code.SettlementAmountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is in repair since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("__qUgZtojEeC60axPepSq7g_1351888922")]
    [Description(@"Cancellation request is in repair since more than one instruction match to the cancellation criteria.")]
    NoMatch = RepairReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is in repair since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("__qeRYNojEeC60axPepSq7g_1238049856")]
    [Description(@"Cancellation request is in repair since the instruction could not be found.")]
    NotFound = RepairReasonV2Code.NotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__qeRYdojEeC60axPepSq7g_279883863")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("__qeRYtojEeC60axPepSq7g_166044797")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid closing transaction amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("__qeRY9ojEeC60axPepSq7g_-37892798")]
    [Description(@"Unrecognised or invalid closing transaction amount.")]
    ClosingTransactionAmount = RepairReasonV2Code.ClosingTransactionAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__qeRZNojEeC60axPepSq7g_-151731864")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RepairReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("__qeRZdojEeC60axPepSq7g_722872355")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RepairReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("__qeRZtojEeC60axPepSq7g_-1741171772")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RepairReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("__qnbUNojEeC60axPepSq7g_-1855010838")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RepairReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("__qnbUdojEeC60axPepSq7g_-1287084503")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed = RepairReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("__qnbUtojEeC60axPepSq7g_-1400923569")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonV2Code.SafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("__qnbU9ojEeC60axPepSq7g_-364921193")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonV2Code.SettlementTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("__qnbVNojEeC60axPepSq7g_-478760259")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonV2Code.SettlementSystemMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("__qnbVdojEeC60axPepSq7g_1732846774")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime = RepairReasonV2Code.ClosingDateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("__qnbVtojEeC60axPepSq7g_-67236091")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonV2Code.TaxStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message was not recognised. Unknown linked reference.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("__qxMUNojEeC60axPepSq7g_-181075157")]
    [Description(@"Message was not recognised. Unknown linked reference.")]
    Unknown = RepairReasonV2Code.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("__qxMUdojEeC60axPepSq7g_1010784247")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport = RepairReasonV2Code.VariableRateSupport, // same ordinal as derivation source for type conversions
    
}
