// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[IsoId("_A1IGoNokEeC60axPepSq7g_1106734346")]
[DisplayName("Settlement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails43
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDetails43 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDetails43( SettlementTransactionType1Choice_ reqSettlementTransactionType )
    {
        SettlementTransactionType = reqSettlementTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [IsoId("_A1R3oNokEeC60axPepSq7g_992895280")]
    [DisplayName("Settlement Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxTp")]
    #endif
    [IsoXmlTag("SttlmTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTransactionType1Choice_ SettlementTransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTransactionType1Choice_ SettlementTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionType1Choice_ SettlementTransactionType { get; init; } 
    #else
    public SettlementTransactionType1Choice_ SettlementTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_A1R3odokEeC60axPepSq7g_109661993")]
    [DisplayName("Hold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldInd")]
    #endif
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HoldIndicator { get; init; } 
    #else
    public System.String? HoldIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_A1R3otokEeC60axPepSq7g_173941599")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityNumeric3Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityNumeric3Choice_? Priority { get; init; } 
    #else
    public PriorityNumeric3Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the Electronic Trade Confirmation (ETC) service provider is to generate or not a settlement instruction.
    /// </summary>
    [IsoId("_A1R3o9okEeC60axPepSq7g_-1001249426")]
    [DisplayName("Settlement Instruction Generation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInstrGnrtn")]
    #endif
    [IsoXmlTag("SttlmInstrGnrtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInstructionGeneration1Choice_? SettlementInstructionGeneration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInstructionGeneration1Choice_? SettlementInstructionGeneration { get; init; } 
    #else
    public SettlementInstructionGeneration1Choice_? SettlementInstructionGeneration { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_A1R3pNokEeC60axPepSq7g_-1998321779")]
    [DisplayName("Settlement Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxCond")]
    #endif
    [IsoXmlTag("SttlmTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition11Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition11Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition11Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_A1R3pdokEeC60axPepSq7g_1591530902")]
    [DisplayName("Partial Settlement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlSttlmInd")]
    #endif
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialSettlementIndicator { get; init; } 
    #else
    public System.String? PartialSettlementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_A1R3ptokEeC60axPepSq7g_416339877")]
    [DisplayName("Beneficial Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrsh")]
    #endif
    [IsoXmlTag("BnfclOwnrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwnership3Choice_? BeneficialOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwnership3Choice_? BeneficialOwnership { get; init; } 
    #else
    public BeneficialOwnership3Choice_? BeneficialOwnership { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_A1bBkNokEeC60axPepSq7g_480619483")]
    [DisplayName("Block Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckTrad")]
    #endif
    [IsoXmlTag("BlckTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockTrade3Choice_? BlockTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockTrade3Choice_? BlockTrade { get; init; } 
    #else
    public BlockTrade3Choice_? BlockTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_A1bBkdokEeC60axPepSq7g_-694571542")]
    [DisplayName("CCP Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCPElgblty")]
    #endif
    [IsoXmlTag("CCPElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CentralCounterPartyEligibility3Choice_? CCPEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CentralCounterPartyEligibility3Choice_? CCPEligibility { get; init; } 
    #else
    public CentralCounterPartyEligibility3Choice_? CCPEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of cash clearing system, eg, cheque clearing.
    /// </summary>
    [IsoId("_A1bBktokEeC60axPepSq7g_1898208786")]
    [DisplayName("Cash Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshClrSys")]
    #endif
    [IsoXmlTag("CshClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashSettlementSystem3Choice_? CashClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSettlementSystem3Choice_? CashClearingSystem { get; init; } 
    #else
    public CashSettlementSystem3Choice_? CashClearingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_A1bBk9okEeC60axPepSq7g_723017761")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType9Choice_? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType9Choice_? ExposureType { get; init; } 
    #else
    public ExposureType9Choice_? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [IsoId("_A1bBlNokEeC60axPepSq7g_787297367")]
    [DisplayName("FX Standing Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxStgInstr")]
    #endif
    [IsoXmlTag("FxStgInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FXStandingInstruction3Choice_? FXStandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FXStandingInstruction3Choice_? FXStandingInstruction { get; init; } 
    #else
    public FXStandingInstruction3Choice_? FXStandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_A1bBldokEeC60axPepSq7g_-387893658")]
    [DisplayName("Currency To Buy Or Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToBuyOrSell")]
    #endif
    [IsoXmlTag("CcyToBuyOrSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #else
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_A1bBltokEeC60axPepSq7g_-1384966011")]
    [DisplayName("Market Client Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClntSd")]
    #endif
    [IsoXmlTag("MktClntSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketClientSide3Choice_? MarketClientSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClientSide3Choice_? MarketClientSide { get; init; } 
    #else
    public MarketClientSide3Choice_? MarketClientSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_A1kykNokEeC60axPepSq7g_-324098183")]
    [DisplayName("Netting Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgElgblty")]
    #endif
    [IsoXmlTag("NetgElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NettingEligibility3Choice_? NettingEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingEligibility3Choice_? NettingEligibility { get; init; } 
    #else
    public NettingEligibility3Choice_? NettingEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_A1kykdokEeC60axPepSq7g_-1499289208")]
    [DisplayName("Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regn")]
    #endif
    [IsoXmlTag("Regn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Registration6Choice_? Registration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Registration6Choice_? Registration { get; init; } 
    #else
    public Registration6Choice_? Registration { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_A1kyktokEeC60axPepSq7g_-1435009602")]
    [DisplayName("Repurchase Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpTp")]
    #endif
    [IsoXmlTag("RpTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepurchaseType11Choice_? RepurchaseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepurchaseType11Choice_? RepurchaseType { get; init; } 
    #else
    public RepurchaseType11Choice_? RepurchaseType { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_A1kyk9okEeC60axPepSq7g_1684766669")]
    [DisplayName("Legal Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRstrctns")]
    #endif
    [IsoXmlTag("LglRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction3Choice_? LegalRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction3Choice_? LegalRestrictions { get; init; } 
    #else
    public Restriction3Choice_? LegalRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_A1kylNokEeC60axPepSq7g_979652054")]
    [DisplayName("Securities RTGS")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesRTGS")]
    #endif
    [IsoXmlTag("SctiesRTGS")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesRTGS3Choice_? SecuritiesRTGS { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesRTGS3Choice_? SecuritiesRTGS { get; init; } 
    #else
    public SecuritiesRTGS3Choice_? SecuritiesRTGS { get; set; } 
    #endif
    
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_A1kyldokEeC60axPepSq7g_-195538971")]
    [DisplayName("Settling Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlgCpcty")]
    #endif
    [IsoXmlTag("SttlgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlingCapacity3Choice_? SettlingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlingCapacity3Choice_? SettlingCapacity { get; init; } 
    #else
    public SettlingCapacity3Choice_? SettlingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_A1ujkNokEeC60axPepSq7g_-131259365")]
    [DisplayName("Settlement System Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSysMtd")]
    #endif
    [IsoXmlTag("SttlmSysMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementSystemMethod3Choice_? SettlementSystemMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementSystemMethod3Choice_? SettlementSystemMethod { get; init; } 
    #else
    public SettlementSystemMethod3Choice_? SettlementSystemMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_A1ujkdokEeC60axPepSq7g_-1306450390")]
    [DisplayName("Tax Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCpcty")]
    #endif
    [IsoXmlTag("TaxCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCapacityParty3Choice_? TaxCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCapacityParty3Choice_? TaxCapacity { get; init; } 
    #else
    public TaxCapacityParty3Choice_? TaxCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_A1ujktokEeC60axPepSq7g_-2011565005")]
    [DisplayName("Stamp Duty Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyInd")]
    #endif
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StampDutyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StampDutyIndicator { get; init; } 
    #else
    public System.String? StampDutyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_A1ujk9okEeC60axPepSq7g_1286329938")]
    [DisplayName("Stamp Duty Tax Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyTaxBsis")]
    #endif
    [IsoXmlTag("StmpDtyTaxBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification38? StampDutyTaxBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification38? StampDutyTaxBasis { get; init; } 
    #else
    public GenericIdentification38? StampDutyTaxBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_A1ujlNokEeC60axPepSq7g_111138913")]
    [DisplayName("Tracking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trckg")]
    #endif
    [IsoXmlTag("Trckg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tracking3Choice_? Tracking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tracking3Choice_? Tracking { get; init; } 
    #else
    public Tracking3Choice_? Tracking { get; set; } 
    #endif
    
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_A1ujldokEeC60axPepSq7g_175418519")]
    [DisplayName("Automatic Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcBrrwg")]
    #endif
    [IsoXmlTag("AutomtcBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutomaticBorrowing5Choice_? AutomaticBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomaticBorrowing5Choice_? AutomaticBorrowing { get; init; } 
    #else
    public AutomaticBorrowing5Choice_? AutomaticBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_A1ujltokEeC60axPepSq7g_-821653834")]
    [DisplayName("Letter Of Guarantee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfGrnt")]
    #endif
    [IsoXmlTag("LttrOfGrnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LetterOfGuarantee3Choice_? LetterOfGuarantee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LetterOfGuarantee3Choice_? LetterOfGuarantee { get; init; } 
    #else
    public LetterOfGuarantee3Choice_? LetterOfGuarantee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_A13tgNokEeC60axPepSq7g_-1919806158")]
    [DisplayName("Return Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrLeg")]
    #endif
    [IsoXmlTag("RtrLeg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ReturnLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReturnLeg { get; init; } 
    #else
    public System.String? ReturnLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [IsoId("_A13tgdokEeC60axPepSq7g_-233816256")]
    [DisplayName("Modification Cancellation Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCxlAllwd")]
    #endif
    [IsoXmlTag("ModCxlAllwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationCancellationAllowed3Choice_? ModificationCancellationAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationCancellationAllowed3Choice_? ModificationCancellationAllowed { get; init; } 
    #else
    public ModificationCancellationAllowed3Choice_? ModificationCancellationAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_A13tgtokEeC60axPepSq7g_-1230888609")]
    [DisplayName("Eligible For Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblForColl")]
    #endif
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibleForCollateral { get; init; } 
    #else
    public System.String? EligibleForCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
