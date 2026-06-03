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
[IsoId("_gCMkoZaMEfC2_67yGLymgA")]
[DisplayName("Settlement Details230")]
public record SettlementDetails230
{
    [IsoId("_gEUrm5aMEfC2_67yGLymgA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public SecuritiesTransactionType59Choice? SecuritiesTransactionType { get; init; }

    [IsoId("_gEUro5aMEfC2_67yGLymgA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition42Choice> SettlementTransactionCondition { get; init; } = [];

    [IsoId("_gEUrq5aMEfC2_67yGLymgA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice? BeneficialOwnership { get; init; }

    [IsoId("_gEUrs5aMEfC2_67yGLymgA")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice? CCPEligibility { get; init; }

    [IsoId("_gEUru5aMEfC2_67yGLymgA")]
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn3Choice? DeliveryReturnReason { get; init; }

    [IsoId("_gEUrw5aMEfC2_67yGLymgA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem6Choice? CashClearingSystem { get; init; }

    [IsoId("_gEUry5aMEfC2_67yGLymgA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType25Choice? ExposureType { get; init; }

    [IsoId("_gEUr05aMEfC2_67yGLymgA")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction4Choice? FXStandingInstruction { get; init; }

    [IsoId("_gEUr25aMEfC2_67yGLymgA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice? MarketClientSide { get; init; }

    [IsoId("_gEUr45aMEfC2_67yGLymgA")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice? NettingEligibility { get; init; }

    [IsoId("_gEUr65aMEfC2_67yGLymgA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice? Registration { get; init; }

    [IsoId("_gEUr85aMEfC2_67yGLymgA")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice? LegalRestrictions { get; init; }

    [IsoId("_gEUr-5aMEfC2_67yGLymgA")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice? SettlingCapacity { get; init; }

    [IsoId("_gEUsA5aMEfC2_67yGLymgA")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice? TaxCapacity { get; init; }

    [IsoId("_gEUsC5aMEfC2_67yGLymgA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    [IsoId("_gEUsE5aMEfC2_67yGLymgA")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking4Choice? Tracking { get; init; }

    [IsoId("_gEVSpJaMEfC2_67yGLymgA")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice? LetterOfGuarantee { get; init; }

    [IsoId("_gEVSrJaMEfC2_67yGLymgA")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    public IsoYesNoIndicator? ReturnLeg { get; init; }

    [IsoId("_gEVStJaMEfC2_67yGLymgA")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed4Choice? ModificationCancellationAllowed { get; init; }

    [IsoId("_gEVSvJaMEfC2_67yGLymgA")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    [IsoId("_gEVSxJaMEfC2_67yGLymgA")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; }

    [IsoId("_gEVSypaMEfC2_67yGLymgA")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; }
}
