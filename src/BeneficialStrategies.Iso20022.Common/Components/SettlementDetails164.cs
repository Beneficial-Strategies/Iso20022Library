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
[IsoId("_VZPrkdEmEeiO-eodGv5iKQ")]
[DisplayName("Settlement Details")]
public record SettlementDetails164
{
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_VrQBidEmEeiO-eodGv5iKQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_VrQBjdEmEeiO-eodGv5iKQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_VrQBkdEmEeiO-eodGv5iKQ")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType47Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_VrQBldEmEeiO-eodGv5iKQ")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition16Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_VrQBmdEmEeiO-eodGv5iKQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_VrQBndEmEeiO-eodGv5iKQ")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_VrQBodEmEeiO-eodGv5iKQ")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_VrQBpdEmEeiO-eodGv5iKQ")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Reason for a delivery return.
    /// </summary>
    [IsoId("_VrQBqdEmEeiO-eodGv5iKQ")]
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_VrQBrdEmEeiO-eodGv5iKQ")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_VrQBsdEmEeiO-eodGv5iKQ")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType16Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies whether the foreign exchange standing instruction in place should apply.
    /// </summary>
    [IsoId("_VrQBtdEmEeiO-eodGv5iKQ")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_VrQBudEmEeiO-eodGv5iKQ")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_VrQBvdEmEeiO-eodGv5iKQ")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_VrQBwdEmEeiO-eodGv5iKQ")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    [IsoId("_VrQBxdEmEeiO-eodGv5iKQ")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType23Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_VrQBydEmEeiO-eodGv5iKQ")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_VrQBzdEmEeiO-eodGv5iKQ")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_VrQB0dEmEeiO-eodGv5iKQ")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_VrQB1dEmEeiO-eodGv5iKQ")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_VrQB2dEmEeiO-eodGv5iKQ")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_VrQB3dEmEeiO-eodGv5iKQ")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_VrQB4dEmEeiO-eodGv5iKQ")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking4Choice_? Tracking { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_VrQB5dEmEeiO-eodGv5iKQ")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing6Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_VrQB6dEmEeiO-eodGv5iKQ")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Indicates whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_VrQB7dEmEeiO-eodGv5iKQ")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnLeg { get; init; }

    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [IsoId("_VrQB8dEmEeiO-eodGv5iKQ")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; }

    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_VrQB9dEmEeiO-eodGv5iKQ")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the delivering securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_VrQB-dEmEeiO-eodGv5iKQ")]
    [DisplayName("Delivering Securities Sub Balance Type")]
    [IsoXmlTag("DlvrgSctiesSubBalTp")]
    public GenericIdentification30? DeliveringSecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the receiving securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_VrQB-9EmEeiO-eodGv5iKQ")]
    [DisplayName("Receiving Securities Sub Balance Type")]
    [IsoXmlTag("RcvgSctiesSubBalTp")]
    public GenericIdentification30? ReceivingSecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator, for example, the restriction type for a market infrastructure.
    /// </summary>
    [IsoId("_VrQB_dEmEeiO-eodGv5iKQ")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; }
}
