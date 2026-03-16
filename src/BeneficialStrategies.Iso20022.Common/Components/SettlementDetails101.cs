// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
[IsoId("_kkwrUWaPEeWZev0W8F756g")]
[DisplayName("Settlement Details")]
public record SettlementDetails101
{
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_k6LhuWaPEeWZev0W8F756g")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_k6LhvWaPEeWZev0W8F756g")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_k6LhwWaPEeWZev0W8F756g")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType21Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_k6LhxWaPEeWZev0W8F756g")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition20Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_k6LhyWaPEeWZev0W8F756g")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_k6LhzWaPEeWZev0W8F756g")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_k6Lh0WaPEeWZev0W8F756g")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_k6Lh1WaPEeWZev0W8F756g")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    [IsoId("_k6Lh2WaPEeWZev0W8F756g")]
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_k6Lh3WaPEeWZev0W8F756g")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_k6Lh4WaPEeWZev0W8F756g")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType16Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies whether the foreign exchange standing instruction in place should apply.
    /// </summary>
    [IsoId("_k6Lh5WaPEeWZev0W8F756g")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_k6Lh6WaPEeWZev0W8F756g")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide4Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_k6Lh7WaPEeWZev0W8F756g")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_k6Lh8WaPEeWZev0W8F756g")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_k6Lh9WaPEeWZev0W8F756g")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType14Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_k6Lh-WaPEeWZev0W8F756g")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_k6Lh_WaPEeWZev0W8F756g")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_k6LiAWaPEeWZev0W8F756g")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_k6LiBWaPEeWZev0W8F756g")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_k6LiCWaPEeWZev0W8F756g")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_k6LiDWaPEeWZev0W8F756g")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_k6LiEWaPEeWZev0W8F756g")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking4Choice_? Tracking { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_k6LiFWaPEeWZev0W8F756g")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing6Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_k6LiGWaPEeWZev0W8F756g")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_k6LiHWaPEeWZev0W8F756g")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnLeg { get; init; }

    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [IsoId("_k6LiIWaPEeWZev0W8F756g")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; }

    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_k6LiJWaPEeWZev0W8F756g")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_k6LiKWaPEeWZev0W8F756g")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_k6LiK2aPEeWZev0W8F756g")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; }
}
