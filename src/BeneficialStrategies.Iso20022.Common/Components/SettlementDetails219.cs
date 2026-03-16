// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Details219.
/// </summary>
[IsoId("_X4-EL4S2Ee-Pv9KR9bv9IA")]
[DisplayName("Settlement Details219")]
public partial record SettlementDetails219
{
    #nullable enable

    /// <summary>
    /// Automatic Borrowing.
    /// </summary>
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing6Choice_? AutomaticBorrowing { get; init; } 

    /// <summary>
    /// Beneficial Ownership.
    /// </summary>
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 

    /// <summary>
    /// Block Trade.
    /// </summary>
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice_? BlockTrade { get; init; } 

    /// <summary>
    /// Cash Clearing System.
    /// </summary>
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 

    /// <summary>
    /// Cash Sub Balance Type.
    /// </summary>
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; } 

    /// <summary>
    /// CCP Eligibility.
    /// </summary>
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 

    /// <summary>
    /// Delivering Securities Sub Balance Type.
    /// </summary>
    [DisplayName("Delivering Securities Sub Balance Type")]
    [IsoXmlTag("DlvrgSctiesSubBalTp")]
    public GenericIdentification30? DeliveringSecuritiesSubBalanceType { get; init; } 

    /// <summary>
    /// Delivery Return Reason.
    /// </summary>
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; } 

    /// <summary>
    /// Eligible For Collateral.
    /// </summary>
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 

    /// <summary>
    /// Exposure Type.
    /// </summary>
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType25Choice_? ExposureType { get; init; } 

    /// <summary>
    /// FX Standing Instruction.
    /// </summary>
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; } 

    /// <summary>
    /// Hold Indicator.
    /// </summary>
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; } 

    /// <summary>
    /// Legal Restrictions.
    /// </summary>
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice_? LegalRestrictions { get; init; } 

    /// <summary>
    /// Letter Of Guarantee.
    /// </summary>
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; } 

    /// <summary>
    /// Market Client Side.
    /// </summary>
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice_? MarketClientSide { get; init; } 

    /// <summary>
    /// Modification Cancellation Allowed.
    /// </summary>
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; } 

    /// <summary>
    /// Netting Eligibility.
    /// </summary>
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice_? NettingEligibility { get; init; } 

    /// <summary>
    /// Partial Settlement Indicator.
    /// </summary>
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; } 

    /// <summary>
    /// Receiving Securities Sub Balance Type.
    /// </summary>
    [DisplayName("Receiving Securities Sub Balance Type")]
    [IsoXmlTag("RcvgSctiesSubBalTp")]
    public GenericIdentification30? ReceivingSecuritiesSubBalanceType { get; init; } 

    /// <summary>
    /// Registration.
    /// </summary>
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice_? Registration { get; init; } 

    /// <summary>
    /// Repurchase Type.
    /// </summary>
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType23Choice_? RepurchaseType { get; init; } 

    /// <summary>
    /// Return Leg.
    /// </summary>
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    public IsoYesNoIndicator? ReturnLeg { get; init; } 

    /// <summary>
    /// Securities RTGS.
    /// </summary>
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; } 

    /// <summary>
    /// Securities Transaction Type.
    /// </summary>
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType47Choice_ SecuritiesTransactionType { get; init; } 

    /// <summary>
    /// Settlement System Method.
    /// </summary>
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; } 

    /// <summary>
    /// Settlement Transaction Condition.
    /// </summary>
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition33Choice_> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Settling Capacity.
    /// </summary>
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; } 

    /// <summary>
    /// Stamp Duty Tax Basis.
    /// </summary>
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 

    /// <summary>
    /// Tax Capacity.
    /// </summary>
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; } 

    /// <summary>
    /// Tracking.
    /// </summary>
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking4Choice_? Tracking { get; init; } 

    
    #nullable disable
    
}
