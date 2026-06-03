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
[IsoId("_WanrkZZ6EfC2_67yGLymgA")]
[DisplayName("Settlement Details222")]
public record SettlementDetails222
{
    [IsoId("_Wdk49ZZ6EfC2_67yGLymgA")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    [IsoId("_Wdk4_ZZ6EfC2_67yGLymgA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition41Choice> SettlementTransactionCondition { get; init; } = [];

    [IsoId("_Wdk5BZZ6EfC2_67yGLymgA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType44Choice SecuritiesTransactionType { get; init; }

    [IsoId("_Wdk5DZZ6EfC2_67yGLymgA")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice? SettlingCapacity { get; init; }

    [IsoId("_Wdk5FZZ6EfC2_67yGLymgA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    [IsoId("_Wdk5HZZ6EfC2_67yGLymgA")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice? SecuritiesRTGS { get; init; }

    [IsoId("_Wdk5JZZ6EfC2_67yGLymgA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice? Registration { get; init; }

    [IsoId("_Wdk5LZZ6EfC2_67yGLymgA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice? BeneficialOwnership { get; init; }

    [IsoId("_Wdk5NZZ6EfC2_67yGLymgA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType25Choice? ExposureType { get; init; }

    [IsoId("_Wdk5PZZ6EfC2_67yGLymgA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem6Choice? CashClearingSystem { get; init; }

    [IsoId("_Wdk5RZZ6EfC2_67yGLymgA")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice? TaxCapacity { get; init; }

    [IsoId("_Wdk5TZZ6EfC2_67yGLymgA")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType22Choice? RepurchaseType { get; init; }

    [IsoId("_Wdk5VZZ6EfC2_67yGLymgA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice? MarketClientSide { get; init; }

    [IsoId("_Wdk5XZZ6EfC2_67yGLymgA")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice? BlockTrade { get; init; }

    [IsoId("_Wdk5ZZZ6EfC2_67yGLymgA")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice? LegalRestrictions { get; init; }

    [IsoId("_Wdk5bZZ6EfC2_67yGLymgA")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice? SettlementSystemMethod { get; init; }

    [IsoId("_Wdk5dZZ6EfC2_67yGLymgA")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice? NettingEligibility { get; init; }

    [IsoId("_Wdk5fZZ6EfC2_67yGLymgA")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice? CCPEligibility { get; init; }

    [IsoId("_Wdk5hZZ6EfC2_67yGLymgA")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice? LetterOfGuarantee { get; init; }

    [IsoId("_Wdk5jZZ6EfC2_67yGLymgA")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    [IsoId("_Wdk5lZZ6EfC2_67yGLymgA")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }
}
