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
[IsoId("_Qd-5rZw0EeazcsnODTksnQ")]
[DisplayName("Settlement Details")]
public record SettlementDetails137
{
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_Qd-5t5w0EeazcsnODTksnQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator7? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_Qd-5u5w0EeazcsnODTksnQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric5Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_Qd-5v5w0EeazcsnODTksnQ")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType34Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_Qd-5w5w0EeazcsnODTksnQ")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition29Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_Qd-5x5w0EeazcsnODTksnQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_Qd-5y5w0EeazcsnODTksnQ")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_Qd-5z5w0EeazcsnODTksnQ")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade5Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_Qd-505w0EeazcsnODTksnQ")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    [IsoId("_Qd-515w0EeazcsnODTksnQ")]
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn4Choice_? DeliveryReturnReason { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_Qd-525w0EeazcsnODTksnQ")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_Qd-535w0EeazcsnODTksnQ")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType17Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies whether the foreign exchange standing instruction in place should apply.
    /// </summary>
    [IsoId("_Qd-545w0EeazcsnODTksnQ")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction5Choice_? FXStandingInstruction { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_QeIhcZw0EeazcsnODTksnQ")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide5Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_QeIhdZw0EeazcsnODTksnQ")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility5Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_QeIheZw0EeazcsnODTksnQ")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration11Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_QeIhfZw0EeazcsnODTksnQ")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType26Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_QeIhgZw0EeazcsnODTksnQ")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction6Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_QeIhhZw0EeazcsnODTksnQ")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_QeIhiZw0EeazcsnODTksnQ")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_QeIhjZw0EeazcsnODTksnQ")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_QeIhkZw0EeazcsnODTksnQ")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_QeIhlZw0EeazcsnODTksnQ")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification47? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_QeIhmZw0EeazcsnODTksnQ")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking5Choice_? Tracking { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_QeIhnZw0EeazcsnODTksnQ")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_QeIhoZw0EeazcsnODTksnQ")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_QeIhpZw0EeazcsnODTksnQ")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnLeg { get; init; }

    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [IsoId("_QeIhqZw0EeazcsnODTksnQ")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed5Choice_? ModificationCancellationAllowed { get; init; }

    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_QeIhrZw0EeazcsnODTksnQ")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_QeIhsZw0EeazcsnODTksnQ")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification47? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_QeIhs5w0EeazcsnODTksnQ")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification47? CashSubBalanceType { get; init; }
}
