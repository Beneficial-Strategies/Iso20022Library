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
/// Details of settlement of a transaction.
/// </summary>
[IsoId("_6dqCxJNLEeWGlc8L7oPDIg")]
[DisplayName("Settlement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails111
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDetails111 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDetails111( SecuritiesTransactionType25Choice_ reqSecuritiesTransactionType )
    {
        SecuritiesTransactionType = reqSecuritiesTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_6dqCzpNLEeWGlc8L7oPDIg")]
    [DisplayName("Hold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldInd")]
    #endif
    [IsoXmlTag("HldInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HoldIndicator7? HoldIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HoldIndicator7? HoldIndicator { get; init; } 
    #else
    public HoldIndicator7? HoldIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_6dqC0pNLEeWGlc8L7oPDIg")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityNumeric5Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityNumeric5Choice_? Priority { get; init; } 
    #else
    public PriorityNumeric5Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_6dqC1pNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesTxTp")]
    #endif
    [IsoXmlTag("SctiesTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTransactionType25Choice_ SecuritiesTransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesTransactionType25Choice_ SecuritiesTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionType25Choice_ SecuritiesTransactionType { get; init; } 
    #else
    public SecuritiesTransactionType25Choice_ SecuritiesTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_6dqC2pNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxCond")]
    #endif
    [IsoXmlTag("SttlmTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition29Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition29Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition29Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_6dqC3pNLEeWGlc8L7oPDIg")]
    [DisplayName("Partial Settlement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlSttlmInd")]
    #endif
    [IsoXmlTag("PrtlSttlmInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    #else
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_6dqC4pNLEeWGlc8L7oPDIg")]
    [DisplayName("Beneficial Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrsh")]
    #endif
    [IsoXmlTag("BnfclOwnrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; } 
    #else
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_6dqC5pNLEeWGlc8L7oPDIg")]
    [DisplayName("Block Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckTrad")]
    #endif
    [IsoXmlTag("BlckTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockTrade5Choice_? BlockTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockTrade5Choice_? BlockTrade { get; init; } 
    #else
    public BlockTrade5Choice_? BlockTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_6dqC6pNLEeWGlc8L7oPDIg")]
    [DisplayName("CCP Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCPElgblty")]
    #endif
    [IsoXmlTag("CCPElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; } 
    #else
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    [IsoId("_6dqC7pNLEeWGlc8L7oPDIg")]
    [DisplayName("Delivery Return Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryRtrRsn")]
    #endif
    [IsoXmlTag("DlvryRtrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReturn4Choice_? DeliveryReturnReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReturn4Choice_? DeliveryReturnReason { get; init; } 
    #else
    public DeliveryReturn4Choice_? DeliveryReturnReason { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_6dqC8pNLEeWGlc8L7oPDIg")]
    [DisplayName("Cash Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshClrSys")]
    #endif
    [IsoXmlTag("CshClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; } 
    #else
    public CashSettlementSystem5Choice_? CashClearingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_6dqC9pNLEeWGlc8L7oPDIg")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType17Choice_? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType17Choice_? ExposureType { get; init; } 
    #else
    public ExposureType17Choice_? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the foreign exchange standing instruction in place should apply.
    /// </summary>
    [IsoId("_6dqC-pNLEeWGlc8L7oPDIg")]
    [DisplayName("FX Standing Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxStgInstr")]
    #endif
    [IsoXmlTag("FxStgInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FXStandingInstruction5Choice_? FXStandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FXStandingInstruction5Choice_? FXStandingInstruction { get; init; } 
    #else
    public FXStandingInstruction5Choice_? FXStandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_6dqC_pNLEeWGlc8L7oPDIg")]
    [DisplayName("Market Client Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClntSd")]
    #endif
    [IsoXmlTag("MktClntSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketClientSide5Choice_? MarketClientSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClientSide5Choice_? MarketClientSide { get; init; } 
    #else
    public MarketClientSide5Choice_? MarketClientSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_6dqDApNLEeWGlc8L7oPDIg")]
    [DisplayName("Netting Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgElgblty")]
    #endif
    [IsoXmlTag("NetgElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NettingEligibility5Choice_? NettingEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingEligibility5Choice_? NettingEligibility { get; init; } 
    #else
    public NettingEligibility5Choice_? NettingEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_6dqDBpNLEeWGlc8L7oPDIg")]
    [DisplayName("Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regn")]
    #endif
    [IsoXmlTag("Regn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Registration11Choice_? Registration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Registration11Choice_? Registration { get; init; } 
    #else
    public Registration11Choice_? Registration { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_6dqDCpNLEeWGlc8L7oPDIg")]
    [DisplayName("Repurchase Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpTp")]
    #endif
    [IsoXmlTag("RpTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepurchaseType20Choice_? RepurchaseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepurchaseType20Choice_? RepurchaseType { get; init; } 
    #else
    public RepurchaseType20Choice_? RepurchaseType { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_6dqDDpNLEeWGlc8L7oPDIg")]
    [DisplayName("Legal Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRstrctns")]
    #endif
    [IsoXmlTag("LglRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    #else
    public Restriction6Choice_? LegalRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_6dqDEpNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities RTGS")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesRTGS")]
    #endif
    [IsoXmlTag("SctiesRTGS")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    #else
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; set; } 
    #endif
    
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_6dqDFpNLEeWGlc8L7oPDIg")]
    [DisplayName("Settling Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlgCpcty")]
    #endif
    [IsoXmlTag("SttlgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; } 
    #else
    public SettlingCapacity8Choice_? SettlingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_6dqDGpNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement System Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSysMtd")]
    #endif
    [IsoXmlTag("SttlmSysMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    #else
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_6dqDHpNLEeWGlc8L7oPDIg")]
    [DisplayName("Tax Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCpcty")]
    #endif
    [IsoXmlTag("TaxCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    #else
    public TaxCapacityParty5Choice_? TaxCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_6dqDIpNLEeWGlc8L7oPDIg")]
    [DisplayName("Stamp Duty Tax Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyTaxBsis")]
    #endif
    [IsoXmlTag("StmpDtyTaxBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    #else
    public GenericIdentification47? StampDutyTaxBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_6dqDJpNLEeWGlc8L7oPDIg")]
    [DisplayName("Tracking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trckg")]
    #endif
    [IsoXmlTag("Trckg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tracking5Choice_? Tracking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tracking5Choice_? Tracking { get; init; } 
    #else
    public Tracking5Choice_? Tracking { get; set; } 
    #endif
    
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_6dqDKpNLEeWGlc8L7oPDIg")]
    [DisplayName("Automatic Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcBrrwg")]
    #endif
    [IsoXmlTag("AutomtcBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; init; } 
    #else
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_6dqDLpNLEeWGlc8L7oPDIg")]
    [DisplayName("Letter Of Guarantee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfGrnt")]
    #endif
    [IsoXmlTag("LttrOfGrnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; init; } 
    #else
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_6dqDMpNLEeWGlc8L7oPDIg")]
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
    [IsoId("_6dqDNpNLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Cancellation Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCxlAllwd")]
    #endif
    [IsoXmlTag("ModCxlAllwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationCancellationAllowed5Choice_? ModificationCancellationAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationCancellationAllowed5Choice_? ModificationCancellationAllowed { get; init; } 
    #else
    public ModificationCancellationAllowed5Choice_? ModificationCancellationAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_6dqDOpNLEeWGlc8L7oPDIg")]
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
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_6dqDPpNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSubBalTp")]
    #endif
    [IsoXmlTag("SctiesSubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification47? SecuritiesSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification47? SecuritiesSubBalanceType { get; init; } 
    #else
    public GenericIdentification47? SecuritiesSubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_6dqDQJNLEeWGlc8L7oPDIg")]
    [DisplayName("Cash Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSubBalTp")]
    #endif
    [IsoXmlTag("CshSubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification47? CashSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification47? CashSubBalanceType { get; init; } 
    #else
    public GenericIdentification47? CashSubBalanceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
