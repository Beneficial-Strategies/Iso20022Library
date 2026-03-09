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
[IsoId("_oKLSQ9xKEd-tnM7aRm4nqg")]
[DisplayName("Settlement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDetails23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDetails23( SecuritiesTransactionType1Choice_ reqSecuritiesTransactionType )
    {
        SecuritiesTransactionType = reqSecuritiesTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_oKLSRdxKEd-tnM7aRm4nqg")]
    [DisplayName("Hold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldInd")]
    #endif
    [IsoXmlTag("HldInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HoldIndicator2? HoldIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HoldIndicator2? HoldIndicator { get; init; } 
    #else
    public HoldIndicator2? HoldIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_oKLSR9xKEd-tnM7aRm4nqg")]
    [DisplayName("Settlement Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxCond")]
    #endif
    [IsoXmlTag("SttlmTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition6Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition6Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition6Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_oKLSSdxKEd-tnM7aRm4nqg")]
    [DisplayName("Securities Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesTxTp")]
    #endif
    [IsoXmlTag("SctiesTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTransactionType1Choice_ SecuritiesTransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesTransactionType1Choice_ SecuritiesTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionType1Choice_ SecuritiesTransactionType { get; init; } 
    #else
    public SecuritiesTransactionType1Choice_ SecuritiesTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_oKLSS9xKEd-tnM7aRm4nqg")]
    [DisplayName("Settling Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlgCpcty")]
    #endif
    [IsoXmlTag("SttlgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlingCapacity1Choice_? SettlingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlingCapacity1Choice_? SettlingCapacity { get; init; } 
    #else
    public SettlingCapacity1Choice_? SettlingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_oKLSTdxKEd-tnM7aRm4nqg")]
    [DisplayName("Stamp Duty Tax Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyTaxBsis")]
    #endif
    [IsoXmlTag("StmpDtyTaxBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification20? StampDutyTaxBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification20? StampDutyTaxBasis { get; init; } 
    #else
    public GenericIdentification20? StampDutyTaxBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_oKLST9xKEd-tnM7aRm4nqg")]
    [DisplayName("Securities RTGS")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesRTGS")]
    #endif
    [IsoXmlTag("SctiesRTGS")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; } 
    #else
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_oKLSUdxKEd-tnM7aRm4nqg")]
    [DisplayName("Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regn")]
    #endif
    [IsoXmlTag("Regn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Registration1Choice_? Registration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Registration1Choice_? Registration { get; init; } 
    #else
    public Registration1Choice_? Registration { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_oKLSU9xKEd-tnM7aRm4nqg")]
    [DisplayName("Beneficial Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrsh")]
    #endif
    [IsoXmlTag("BnfclOwnrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwnership1Choice_? BeneficialOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwnership1Choice_? BeneficialOwnership { get; init; } 
    #else
    public BeneficialOwnership1Choice_? BeneficialOwnership { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_oKLSVdxKEd-tnM7aRm4nqg")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType4Choice_? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType4Choice_? ExposureType { get; init; } 
    #else
    public ExposureType4Choice_? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_oKLSV9xKEd-tnM7aRm4nqg")]
    [DisplayName("Cash Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshClrSys")]
    #endif
    [IsoXmlTag("CshClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashSettlementSystem1Choice_? CashClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSettlementSystem1Choice_? CashClearingSystem { get; init; } 
    #else
    public CashSettlementSystem1Choice_? CashClearingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_oKLSWdxKEd-tnM7aRm4nqg")]
    [DisplayName("Tax Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCpcty")]
    #endif
    [IsoXmlTag("TaxCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCapacityParty1Choice_? TaxCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCapacityParty1Choice_? TaxCapacity { get; init; } 
    #else
    public TaxCapacityParty1Choice_? TaxCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_oKLSW9xKEd-tnM7aRm4nqg")]
    [DisplayName("Repurchase Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpTp")]
    #endif
    [IsoXmlTag("RpTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepurchaseType3Choice_? RepurchaseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepurchaseType3Choice_? RepurchaseType { get; init; } 
    #else
    public RepurchaseType3Choice_? RepurchaseType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_oKLSXdxKEd-tnM7aRm4nqg")]
    [DisplayName("Market Client Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClntSd")]
    #endif
    [IsoXmlTag("MktClntSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketClientSide1Choice_? MarketClientSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClientSide1Choice_? MarketClientSide { get; init; } 
    #else
    public MarketClientSide1Choice_? MarketClientSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_oKLSX9xKEd-tnM7aRm4nqg")]
    [DisplayName("Block Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckTrad")]
    #endif
    [IsoXmlTag("BlckTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockTrade1Choice_? BlockTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockTrade1Choice_? BlockTrade { get; init; } 
    #else
    public BlockTrade1Choice_? BlockTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_oKLSYdxKEd-tnM7aRm4nqg")]
    [DisplayName("Legal Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRstrctns")]
    #endif
    [IsoXmlTag("LglRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction1Choice_? LegalRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction1Choice_? LegalRestrictions { get; init; } 
    #else
    public Restriction1Choice_? LegalRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_oKLSY9xKEd-tnM7aRm4nqg")]
    [DisplayName("Settlement System Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSysMtd")]
    #endif
    [IsoXmlTag("SttlmSysMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementSystemMethod1Choice_? SettlementSystemMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementSystemMethod1Choice_? SettlementSystemMethod { get; init; } 
    #else
    public SettlementSystemMethod1Choice_? SettlementSystemMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_oKLSZdxKEd-tnM7aRm4nqg")]
    [DisplayName("Netting Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgElgblty")]
    #endif
    [IsoXmlTag("NetgElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NettingEligibility1Choice_? NettingEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingEligibility1Choice_? NettingEligibility { get; init; } 
    #else
    public NettingEligibility1Choice_? NettingEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_oKLSZ9xKEd-tnM7aRm4nqg")]
    [DisplayName("CCP Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCPElgblty")]
    #endif
    [IsoXmlTag("CCPElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CentralCounterPartyEligibility1Choice_? CCPEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CentralCounterPartyEligibility1Choice_? CCPEligibility { get; init; } 
    #else
    public CentralCounterPartyEligibility1Choice_? CCPEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_oKLSadxKEd-tnM7aRm4nqg")]
    [DisplayName("Letter Of Guarantee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfGrnt")]
    #endif
    [IsoXmlTag("LttrOfGrnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LetterOfGuarantee1Choice_? LetterOfGuarantee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LetterOfGuarantee1Choice_? LetterOfGuarantee { get; init; } 
    #else
    public LetterOfGuarantee1Choice_? LetterOfGuarantee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_oKLSa9xKEd-tnM7aRm4nqg")]
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
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_oKLSbdxKEd-tnM7aRm4nqg")]
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
