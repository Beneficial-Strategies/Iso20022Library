// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Details216.
/// </summary>
[IsoId("_WZToo4S2Ee-Pv9KR9bv9IA")]
[DisplayName("Settlement Details216")]
public partial record SettlementDetails216
{
    #nullable enable

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
    /// CCP Eligibility.
    /// </summary>
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 

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
    public RepurchaseType22Choice_? RepurchaseType { get; init; } 

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
    public required SecuritiesTransactionType44Choice_ SecuritiesTransactionType { get; init; } 

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
    public ValueList<SettlementTransactionCondition34Choice_> SettlementTransactionCondition { get; init; } = [];

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

    
    #nullable disable
    
}
