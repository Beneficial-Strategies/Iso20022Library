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
[IsoId("_8jxtIdYPEeiHVOfMzoKxnA")]
[DisplayName("Settlement Details")]
public record SettlementDetails171
{
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    [IsoId("_82E-FdYPEeiHVOfMzoKxnA")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_82E-GdYPEeiHVOfMzoKxnA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType43Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    [IsoId("_82E-HdYPEeiHVOfMzoKxnA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition16Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    [IsoId("_82E-IdYPEeiHVOfMzoKxnA")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    [IsoId("_82E-JdYPEeiHVOfMzoKxnA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    [IsoId("_82E-KdYPEeiHVOfMzoKxnA")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_82E-LdYPEeiHVOfMzoKxnA")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_82E-MdYPEeiHVOfMzoKxnA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade having caused the collateral movement.
    /// </summary>
    [IsoId("_82E-NdYPEeiHVOfMzoKxnA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType16Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    [IsoId("_82E-OdYPEeiHVOfMzoKxnA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    [IsoId("_82E-PdYPEeiHVOfMzoKxnA")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration was to occur upon receipt.
    /// </summary>
    [IsoId("_82E-QdYPEeiHVOfMzoKxnA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    [IsoId("_82E-RdYPEeiHVOfMzoKxnA")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType22Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_82E-SdYPEeiHVOfMzoKxnA")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_82E-TdYPEeiHVOfMzoKxnA")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_82E-UdYPEeiHVOfMzoKxnA")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_82E-VdYPEeiHVOfMzoKxnA")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_82E-WdYPEeiHVOfMzoKxnA")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_82E-XdYPEeiHVOfMzoKxnA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_82E-YdYPEeiHVOfMzoKxnA")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing6Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement was executed using a letter of guarantee or if the physical certificates were used.
    /// </summary>
    [IsoId("_82E-ZdYPEeiHVOfMzoKxnA")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_82E-adYPEeiHVOfMzoKxnA")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_82E-bdYPEeiHVOfMzoKxnA")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator, for example, the restriction type for a market infrastructure.
    /// </summary>
    [IsoId("_82E-b9YPEeiHVOfMzoKxnA")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; }
}
