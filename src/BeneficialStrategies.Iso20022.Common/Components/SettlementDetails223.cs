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
[IsoId("_yFH1AZaAEfC2_67yGLymgA")]
[DisplayName("Settlement Details223")]
public record SettlementDetails223
{
    [IsoId("_yH0juZaAEfC2_67yGLymgA")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice? Priority { get; init; }

    [IsoId("_yH0jwZaAEfC2_67yGLymgA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType46Choice SecuritiesTransactionType { get; init; }

    [IsoId("_yH0jyZaAEfC2_67yGLymgA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition42Choice> SettlementTransactionCondition { get; init; } = [];

    [IsoId("_yH0j0ZaAEfC2_67yGLymgA")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    [IsoId("_yH0j2ZaAEfC2_67yGLymgA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice? BeneficialOwnership { get; init; }

    [IsoId("_yH0j4ZaAEfC2_67yGLymgA")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice? BlockTrade { get; init; }

    [IsoId("_yH0j6ZaAEfC2_67yGLymgA")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice? CCPEligibility { get; init; }

    [IsoId("_yH0j8ZaAEfC2_67yGLymgA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem6Choice? CashClearingSystem { get; init; }

    [IsoId("_yH0j-ZaAEfC2_67yGLymgA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType25Choice? ExposureType { get; init; }

    [IsoId("_yH0kAZaAEfC2_67yGLymgA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice? MarketClientSide { get; init; }

    [IsoId("_yH0kCZaAEfC2_67yGLymgA")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice? NettingEligibility { get; init; }

    [IsoId("_yH0kEZaAEfC2_67yGLymgA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice? Registration { get; init; }

    [IsoId("_yH0kGZaAEfC2_67yGLymgA")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType22Choice? RepurchaseType { get; init; }

    [IsoId("_yH0kIZaAEfC2_67yGLymgA")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice? LegalRestrictions { get; init; }

    [IsoId("_yH0kKZaAEfC2_67yGLymgA")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice? SecuritiesRTGS { get; init; }

    [IsoId("_yH0kMZaAEfC2_67yGLymgA")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice? SettlingCapacity { get; init; }

    [IsoId("_yH0kOZaAEfC2_67yGLymgA")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice? SettlementSystemMethod { get; init; }

    [IsoId("_yH0kQZaAEfC2_67yGLymgA")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice? TaxCapacity { get; init; }

    [IsoId("_yH0kSZaAEfC2_67yGLymgA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    [IsoId("_yH0kUZaAEfC2_67yGLymgA")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing6Choice? AutomaticBorrowing { get; init; }

    [IsoId("_yH0kWZaAEfC2_67yGLymgA")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice? LetterOfGuarantee { get; init; }

    [IsoId("_yH0kYZaAEfC2_67yGLymgA")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    [IsoId("_yH0kaZaAEfC2_67yGLymgA")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; }

    [IsoId("_yH0kb5aAEfC2_67yGLymgA")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; }
}
