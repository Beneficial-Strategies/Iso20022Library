// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[IsoId("_UgE299p-Ed-ak6NoX_4Aeg_-1038698170")]
[DisplayName("Settlement Details")]
public record SettlementDetails6
{
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    [IsoId("_UgE2-Np-Ed-ak6NoX_4Aeg_-1857651851")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric1Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_UgE2-dp-Ed-ak6NoX_4Aeg_-425342402")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType3Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    [IsoId("_UgE2-tp-Ed-ak6NoX_4Aeg_-1422414755")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition1Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    [IsoId("_UgE2-9p-Ed-ak6NoX_4Aeg_-1358135149")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    [IsoId("_UgE2_Np-Ed-ak6NoX_4Aeg_1761641122")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership1Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    [IsoId("_UgOA4Np-Ed-ak6NoX_4Aeg_1056526507")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade1Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_UgOA4dp-Ed-ak6NoX_4Aeg_-118664518")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility1Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, eg, cheque clearing.
    /// </summary>
    [IsoId("_UgOA4tp-Ed-ak6NoX_4Aeg_-1051457265")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem1Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade having caused the collateral movement.
    /// </summary>
    [IsoId("_UgOA49p-Ed-ak6NoX_4Aeg_2068319006")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType1Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    [IsoId("_UgOA5Np-Ed-ak6NoX_4Aeg_188013366")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide1Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    [IsoId("_UgOA5dp-Ed-ak6NoX_4Aeg_252292972")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility1Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration was to occur upon receipt.
    /// </summary>
    [IsoId("_UgOA5tp-Ed-ak6NoX_4Aeg_-922898053")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration1Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    [IsoId("_UgOA59p-Ed-ak6NoX_4Aeg_-1628012668")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType3Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_UgOA6Np-Ed-ak6NoX_4Aeg_1491763603")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction1Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_UgOA6dp-Ed-ak6NoX_4Aeg_1556043209")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_UgXx4Np-Ed-ak6NoX_4Aeg_380852184")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity1Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_UgXx4dp-Ed-ak6NoX_4Aeg_-324262431")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod1Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_UgXx4tp-Ed-ak6NoX_4Aeg_-1499453456")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty1Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_UgXx49p-Ed-ak6NoX_4Aeg_-1435173850")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification20? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_UgXx5Np-Ed-ak6NoX_4Aeg_979487806")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing1Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement was executed using a letter of guarantee or if the physical certificates were used.
    /// </summary>
    [IsoId("_UgXx5dp-Ed-ak6NoX_4Aeg_-195703219")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee1Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_UgXx5tp-Ed-ak6NoX_4Aeg_-1215001463")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }
}
