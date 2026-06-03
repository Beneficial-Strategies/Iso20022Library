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
[IsoId("_YNfwsZZ1EfC2_67yGLymgA")]
[DisplayName("Settlement Details220")]
public record SettlementDetails220
{
    [IsoId("_YQZTvZZ1EfC2_67yGLymgA")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    [IsoId("_YQZTxZZ1EfC2_67yGLymgA")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice? Priority { get; init; }

    [IsoId("_YQZTzZZ1EfC2_67yGLymgA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType47Choice SecuritiesTransactionType { get; init; }

    [IsoId("_YQZT1ZZ1EfC2_67yGLymgA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition40Choice> SettlementTransactionCondition { get; init; } = [];

    [IsoId("_YQZT3ZZ1EfC2_67yGLymgA")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    [IsoId("_YQZT5ZZ1EfC2_67yGLymgA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice? BeneficialOwnership { get; init; }

    [IsoId("_YQZT7ZZ1EfC2_67yGLymgA")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice? BlockTrade { get; init; }

    [IsoId("_YQZT9ZZ1EfC2_67yGLymgA")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice? CCPEligibility { get; init; }

    [IsoId("_YQZT_ZZ1EfC2_67yGLymgA")]
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn3Choice? DeliveryReturnReason { get; init; }

    [IsoId("_YQZUBZZ1EfC2_67yGLymgA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem6Choice? CashClearingSystem { get; init; }

    [IsoId("_YQZUDZZ1EfC2_67yGLymgA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType25Choice? ExposureType { get; init; }

    [IsoId("_YQZUFZZ1EfC2_67yGLymgA")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction4Choice? FXStandingInstruction { get; init; }

    [IsoId("_YQZUHZZ1EfC2_67yGLymgA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice? MarketClientSide { get; init; }

    [IsoId("_YQZUJZZ1EfC2_67yGLymgA")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice? NettingEligibility { get; init; }

    [IsoId("_YQZULZZ1EfC2_67yGLymgA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice? Registration { get; init; }

    [IsoId("_YQZUNZZ1EfC2_67yGLymgA")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType23Choice? RepurchaseType { get; init; }

    [IsoId("_YQZUPZZ1EfC2_67yGLymgA")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice? LegalRestrictions { get; init; }

    [IsoId("_YQZURZZ1EfC2_67yGLymgA")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice? SecuritiesRTGS { get; init; }

    [IsoId("_YQZUTZZ1EfC2_67yGLymgA")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice? SettlingCapacity { get; init; }

    [IsoId("_YQZUVZZ1EfC2_67yGLymgA")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice? SettlementSystemMethod { get; init; }

    [IsoId("_YQZUXZZ1EfC2_67yGLymgA")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice? TaxCapacity { get; init; }

    [IsoId("_YQZUZZZ1EfC2_67yGLymgA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    [IsoId("_YQZUbZZ1EfC2_67yGLymgA")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking4Choice? Tracking { get; init; }

    [IsoId("_YQZUdZZ1EfC2_67yGLymgA")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing6Choice? AutomaticBorrowing { get; init; }

    [IsoId("_YQZUfZZ1EfC2_67yGLymgA")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice? LetterOfGuarantee { get; init; }

    [IsoId("_YQZUhZZ1EfC2_67yGLymgA")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    public IsoYesNoIndicator? ReturnLeg { get; init; }

    [IsoId("_YQZUjZZ1EfC2_67yGLymgA")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed4Choice? ModificationCancellationAllowed { get; init; }

    [IsoId("_YQZUlZZ1EfC2_67yGLymgA")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    [IsoId("_YQZUnZZ1EfC2_67yGLymgA")]
    [DisplayName("Delivering Securities Sub Balance Type")]
    [IsoXmlTag("DlvrgSctiesSubBalTp")]
    public GenericIdentification30? DeliveringSecuritiesSubBalanceType { get; init; }

    [IsoId("_YQZUo5Z1EfC2_67yGLymgA")]
    [DisplayName("Receiving Securities Sub Balance Type")]
    [IsoXmlTag("RcvgSctiesSubBalTp")]
    public GenericIdentification30? ReceivingSecuritiesSubBalanceType { get; init; }

    [IsoId("_YQZUqZZ1EfC2_67yGLymgA")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; }
}
