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
[IsoId("_bMtl4ST6EeOSHvJr_wacAw")]
[DisplayName("Settlement Details")]
public record SettlementDetails70
{
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    [IsoId("_bkEV9yT6EeOSHvJr_wacAw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric1Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_bkEV_yT6EeOSHvJr_wacAw")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType10Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    [IsoId("_bkEWByT6EeOSHvJr_wacAw")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition12Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    [IsoId("_bkEWDyT6EeOSHvJr_wacAw")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    [IsoId("_bkEWFyT6EeOSHvJr_wacAw")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership1Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    [IsoId("_bkEWHyT6EeOSHvJr_wacAw")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade1Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_bkEWJyT6EeOSHvJr_wacAw")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility1Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_bkEWLyT6EeOSHvJr_wacAw")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem1Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade having caused the collateral movement.
    /// </summary>
    [IsoId("_bkEWNyT6EeOSHvJr_wacAw")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType10Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    [IsoId("_bkEWPyT6EeOSHvJr_wacAw")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide1Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    [IsoId("_bkEWRyT6EeOSHvJr_wacAw")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility1Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration was to occur upon receipt.
    /// </summary>
    [IsoId("_bkEWTyT6EeOSHvJr_wacAw")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration1Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    [IsoId("_bkEWVyT6EeOSHvJr_wacAw")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType3Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_bkEWXyT6EeOSHvJr_wacAw")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction1Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_bkEWZyT6EeOSHvJr_wacAw")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_bkEWbyT6EeOSHvJr_wacAw")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity4Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_bkEWdyT6EeOSHvJr_wacAw")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod1Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_bkEWfyT6EeOSHvJr_wacAw")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty1Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_bkEWhyT6EeOSHvJr_wacAw")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification20? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_bkEWjyT6EeOSHvJr_wacAw")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing1Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement was executed using a letter of guarantee or if the physical certificates were used.
    /// </summary>
    [IsoId("_bkEWlyT6EeOSHvJr_wacAw")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee1Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_bkEWnyT6EeOSHvJr_wacAw")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_bkEWpyT6EeOSHvJr_wacAw")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification20? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_bkEWqST6EeOSHvJr_wacAw")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification20? CashSubBalanceType { get; init; }
}
