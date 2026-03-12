// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[IsoId("_A1IGoNokEeC60axPepSq7g_1106734346")]
[DisplayName("Settlement Details")]
public partial record SettlementDetails43
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [IsoId("_A1R3oNokEeC60axPepSq7g_992895280")]
    [DisplayName("Settlement Transaction Type")]
    [IsoXmlTag("SttlmTxTp")]
    public required SettlementTransactionType1Choice_ SettlementTransactionType { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_A1R3odokEeC60axPepSq7g_109661993")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_A1R3otokEeC60axPepSq7g_173941599")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric3Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Specifies if the Electronic Trade Confirmation (ETC) service provider is to generate or not a settlement instruction.
    /// </summary>
    [IsoId("_A1R3o9okEeC60axPepSq7g_-1001249426")]
    [DisplayName("Settlement Instruction Generation")]
    [IsoXmlTag("SttlmInstrGnrtn")]
    public SettlementInstructionGeneration1Choice_? SettlementInstructionGeneration { get; init; } 
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_A1R3pNokEeC60axPepSq7g_-1998321779")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public SettlementTransactionCondition11Choice_? SettlementTransactionCondition { get; init; } 
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_A1R3pdokEeC60axPepSq7g_1591530902")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_A1R3ptokEeC60axPepSq7g_416339877")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership3Choice_? BeneficialOwnership { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_A1bBkNokEeC60axPepSq7g_480619483")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade3Choice_? BlockTrade { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_A1bBkdokEeC60axPepSq7g_-694571542")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility3Choice_? CCPEligibility { get; init; } 
    
    /// <summary>
    /// Specifies the category of cash clearing system, eg, cheque clearing.
    /// </summary>
    [IsoId("_A1bBktokEeC60axPepSq7g_1898208786")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem3Choice_? CashClearingSystem { get; init; } 
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_A1bBk9okEeC60axPepSq7g_723017761")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType9Choice_? ExposureType { get; init; } 
    
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [IsoId("_A1bBlNokEeC60axPepSq7g_787297367")]
    [DisplayName("FX Standing Instruction")]
    [IsoXmlTag("FxStgInstr")]
    public FXStandingInstruction3Choice_? FXStandingInstruction { get; init; } 
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_A1bBldokEeC60axPepSq7g_-387893658")]
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_A1bBltokEeC60axPepSq7g_-1384966011")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide3Choice_? MarketClientSide { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_A1kykNokEeC60axPepSq7g_-324098183")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility3Choice_? NettingEligibility { get; init; } 
    
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_A1kykdokEeC60axPepSq7g_-1499289208")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration6Choice_? Registration { get; init; } 
    
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_A1kyktokEeC60axPepSq7g_-1435009602")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType11Choice_? RepurchaseType { get; init; } 
    
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_A1kyk9okEeC60axPepSq7g_1684766669")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction3Choice_? LegalRestrictions { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_A1kylNokEeC60axPepSq7g_979652054")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS3Choice_? SecuritiesRTGS { get; init; } 
    
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_A1kyldokEeC60axPepSq7g_-195538971")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity3Choice_? SettlingCapacity { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_A1ujkNokEeC60axPepSq7g_-131259365")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod3Choice_? SettlementSystemMethod { get; init; } 
    
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_A1ujkdokEeC60axPepSq7g_-1306450390")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty3Choice_? TaxCapacity { get; init; } 
    
    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_A1ujktokEeC60axPepSq7g_-2011565005")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StampDutyIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_A1ujk9okEeC60axPepSq7g_1286329938")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification38? StampDutyTaxBasis { get; init; } 
    
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_A1ujlNokEeC60axPepSq7g_111138913")]
    [DisplayName("Tracking")]
    [IsoXmlTag("Trckg")]
    public Tracking3Choice_? Tracking { get; init; } 
    
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_A1ujldokEeC60axPepSq7g_175418519")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing5Choice_? AutomaticBorrowing { get; init; } 
    
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_A1ujltokEeC60axPepSq7g_-821653834")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee3Choice_? LetterOfGuarantee { get; init; } 
    
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_A13tgNokEeC60axPepSq7g_-1919806158")]
    [DisplayName("Return Leg")]
    [IsoXmlTag("RtrLeg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [IsoId("_A13tgdokEeC60axPepSq7g_-233816256")]
    [DisplayName("Modification Cancellation Allowed")]
    [IsoXmlTag("ModCxlAllwd")]
    public ModificationCancellationAllowed3Choice_? ModificationCancellationAllowed { get; init; } 
    
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_A13tgtokEeC60axPepSq7g_-1230888609")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    
    
    #nullable disable
    
}
