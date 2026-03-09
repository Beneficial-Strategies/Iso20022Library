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
[IsoId("_5m5Z95NLEeWGlc8L7oPDIg")]
[DisplayName("Settlement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails104
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    [IsoId("_5m5Z_ZNLEeWGlc8L7oPDIg")]
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
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    [IsoId("_5m5aAZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxCond")]
    #endif
    [IsoXmlTag("SttlmTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition22Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition22Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition22Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_5m5aBZNLEeWGlc8L7oPDIg")]
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
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_5m5aCZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_5m5aDZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    [IsoId("_5m5aEZNLEeWGlc8L7oPDIg")]
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
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_5m5aFZNLEeWGlc8L7oPDIg")]
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
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_5m5aGZNLEeWGlc8L7oPDIg")]
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
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    [IsoId("_5m5aHZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    [IsoId("_5m5aIZNLEeWGlc8L7oPDIg")]
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
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_5m5aJZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_5m5aKZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    [IsoId("_5m5aLZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_5m5aMZNLEeWGlc8L7oPDIg")]
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
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_5m5aNZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    [IsoId("_5m5aOZNLEeWGlc8L7oPDIg")]
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
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_5m5aPZNLEeWGlc8L7oPDIg")]
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
