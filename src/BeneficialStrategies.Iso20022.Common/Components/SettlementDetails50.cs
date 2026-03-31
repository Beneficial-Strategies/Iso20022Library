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
[IsoId("_0gZQdQlIEeGATtfOBToyew_-768277771")]
[DisplayName("Settlement Details")]
public record SettlementDetails50
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_0gZQdglIEeGATtfOBToyew_519660314")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public SecuritiesTransactionType9Choice_? SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_0gZQdwlIEeGATtfOBToyew_-2014168931")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition12Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_0gZQeAlIEeGATtfOBToyew_-540334033")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership1Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_0gjBcAlIEeGATtfOBToyew_1760488557")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility1Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    [IsoId("_0gjBcQlIEeGATtfOBToyew_373850484")]
    [DisplayName("Delivery Return Reason")]
    [IsoXmlTag("DlvryRtrRsn")]
    public DeliveryReturn1Choice_? DeliveryReturnReason { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, eg, cheque clearing.
    /// </summary>
    [IsoId("_0gjBcglIEeGATtfOBToyew_476590773")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem1Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_0gjBcwlIEeGATtfOBToyew_1340390539")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType3Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [IsoId("_0gjBdAlIEeGATtfOBToyew_1329291762")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction1Choice_? FXStandingInstruction { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_0gjBdQlIEeGATtfOBToyew_1942647530")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide1Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_0gsLYAlIEeGATtfOBToyew_494348940")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility1Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_0gsLYQlIEeGATtfOBToyew_1194135032")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration1Choice_? Registration { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_0gsLYglIEeGATtfOBToyew_1950792467")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction1Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_0gsLYwlIEeGATtfOBToyew_1315760621")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity1Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_0gsLZAlIEeGATtfOBToyew_-1901186337")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty1Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_0gsLZQlIEeGATtfOBToyew_399636253")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification20? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_0g18YAlIEeGATtfOBToyew_-1245454193")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking1Choice_? Tracking { get; init; }

    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_0g18YQlIEeGATtfOBToyew_1144589254")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee1Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_0g18YglIEeGATtfOBToyew_1423858396")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnLeg { get; init; }

    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [IsoId("_0g18YwlIEeGATtfOBToyew_1893934806")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed1Choice_? ModificationCancellationAllowed { get; init; }

    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_0g18ZAlIEeGATtfOBToyew_-1567358663")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_0g18ZQlIEeGATtfOBToyew_1632003248")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification20? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_0g_tYAlIEeGATtfOBToyew_1501336465")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification20? CashSubBalanceType { get; init; }
}
