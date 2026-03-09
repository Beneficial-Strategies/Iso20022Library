// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZvpTINp-Ed-ak6NoX_4Aeg_663303244")]
[Description(@"Specifies the reason why the instruction is in repair.")]
[Derivations(typeof(RepairReason4Code),typeof(RepairReason7Code),typeof(RepairReason5Code),typeof(RepairReason6Code))]
public enum RepairReasonV2Code
{
    /// <summary>
    /// Unrecognised or invalid closing transaction amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("__8M6kNojEeC60axPepSq7g_-1715904236")]
    [Description(@"Unrecognised or invalid closing transaction amount.")]
    ClosingTransactionAmount,
    
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__8M6kdojEeC60axPepSq7g_-1302316442")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZvpTIdp-Ed-ak6NoX_4Aeg_549464178")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatch,
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZvpTItp-Ed-ak6NoX_4Aeg_-625726847")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZvpTI9p-Ed-ak6NoX_4Aeg_-1330841462")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZvpTJNp-Ed-ak6NoX_4Aeg_314425973")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZvpTJdp-Ed-ak6NoX_4Aeg_1853214415")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZvpTJtp-Ed-ak6NoX_4Aeg_678023390")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZvpTJ9p-Ed-ak6NoX_4Aeg_-27091225")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZvpTKNp-Ed-ak6NoX_4Aeg_-1138002644")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount,
    
    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZvpTKdp-Ed-ak6NoX_4Aeg_1981773627")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZvzEINp-Ed-ak6NoX_4Aeg_1276659012")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security,
    
    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZvzEIdp-Ed-ak6NoX_4Aeg_-1373040849")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZvzEItp-Ed-ak6NoX_4Aeg_165747593")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ZvzEI9p-Ed-ak6NoX_4Aeg_1469497830")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference,
    
    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_ZvzEJNp-Ed-ak6NoX_4Aeg_294306805")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicator,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZvzEJdp-Ed-ak6NoX_4Aeg_-410807810")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZvzEJtp-Ed-ak6NoX_4Aeg_1234459625")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZvzEJ9p-Ed-ak6NoX_4Aeg_-1521719229")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency,
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZvzEKNp-Ed-ak6NoX_4Aeg_-930927811")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZvzEKdp-Ed-ak6NoX_4Aeg_-1636042426")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_Zv81INp-Ed-ak6NoX_4Aeg_9225009")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    Reference,
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_Zv81Idp-Ed-ak6NoX_4Aeg_1548013451")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Zv81Itp-Ed-ak6NoX_4Aeg_372822426")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Zv81I9p-Ed-ak6NoX_4Aeg_-332292189")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Zv81JNp-Ed-ak6NoX_4Aeg_1312975246")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Zv81Jdp-Ed-ak6NoX_4Aeg_-1443203608")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,
    
    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Zv81Jtp-Ed-ak6NoX_4Aeg_1676572663")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Zv81J9p-Ed-ak6NoX_4Aeg_971458048")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Zv81KNp-Ed-ak6NoX_4Aeg_-1678241813")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Zv81Kdp-Ed-ak6NoX_4Aeg_-139453371")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Zv81Ktp-Ed-ak6NoX_4Aeg_-1314644396")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZwF_ENp-Ed-ak6NoX_4Aeg_-1942720310")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus,
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZwF_Edp-Ed-ak6NoX_4Aeg_-297452875")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport,
    
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZwF_Etp-Ed-ak6NoX_4Aeg_-370569474")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ZwF_E9p-Ed-ak6NoX_4Aeg_-1545760499")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRepair,
    
    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_ZwF_FNp-Ed-ak6NoX_4Aeg_2044092182")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRepair,
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ZwF_Fdp-Ed-ak6NoX_4Aeg_-605607679")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRepair,
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_ZwF_Ftp-Ed-ak6NoX_4Aeg_933180763")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRepair,
    
    /// <summary>
    /// Cancellation request is in repair since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZwF_F9p-Ed-ak6NoX_4Aeg_-242010262")]
    [Description(@"Cancellation request is in repair since more than one instruction match to the cancellation criteria.")]
    NoMatch,
    
    /// <summary>
    /// Cancellation request is in repair since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_ZwF_GNp-Ed-ak6NoX_4Aeg_-947124877")]
    [Description(@"Cancellation request is in repair since the instruction could not be found.")]
    NotFound,
    
    /// <summary>
    /// Message was not recognised. Unknown linked reference.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZwF_Gdp-Ed-ak6NoX_4Aeg_698142558")]
    [Description(@"Message was not recognised. Unknown linked reference.")]
    Unknown,
    
    /// <summary>
    /// Unrecognised, invalid or missing Place of Safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ZwPwENp-Ed-ak6NoX_4Aeg_960241794")]
    [Description(@"Unrecognised, invalid or missing Place of Safekeeping.")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ZwPwEdp-Ed-ak6NoX_4Aeg_-1033495231")]
    [Description(@"Required stamp duty information is missing.")]
    StampDuty,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZwPwEtp-Ed-ak6NoX_4Aeg_53777718")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZwPwE9p-Ed-ak6NoX_4Aeg_-124915347")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZwPwFNp-Ed-ak6NoX_4Aeg_-1413945438")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZwPwFdp-Ed-ak6NoX_4Aeg_-136014124")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZwPwFtp-Ed-ak6NoX_4Aeg_-1425044215")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1,
    
}
