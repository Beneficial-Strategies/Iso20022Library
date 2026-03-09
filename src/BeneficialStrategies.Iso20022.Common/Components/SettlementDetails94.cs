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
[IsoId("_RcXn_TqEEeWVrPy0StzzSg")]
[DisplayName("Settlement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails94
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_R7dXRzqEEeWVrPy0StzzSg")]
    [DisplayName("Securities Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesTxTp")]
    #endif
    [IsoXmlTag("SctiesTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionType21Choice_? SecuritiesTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionType21Choice_? SecuritiesTransactionType { get; init; } 
    #else
    public SecuritiesTransactionType21Choice_? SecuritiesTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_R7dXSzqEEeWVrPy0StzzSg")]
    [DisplayName("Settlement Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxCond")]
    #endif
    [IsoXmlTag("SttlmTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition16Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition16Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition16Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_R7dXTzqEEeWVrPy0StzzSg")]
    [DisplayName("Beneficial Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrsh")]
    #endif
    [IsoXmlTag("BnfclOwnrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 
    #else
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_R7dXUzqEEeWVrPy0StzzSg")]
    [DisplayName("CCP Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCPElgblty")]
    #endif
    [IsoXmlTag("CCPElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 
    #else
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    [IsoId("_R7dXVzqEEeWVrPy0StzzSg")]
    [DisplayName("Delivery Return Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryRtrRsn")]
    #endif
    [IsoXmlTag("DlvryRtrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; } 
    #else
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_R7dXWzqEEeWVrPy0StzzSg")]
    [DisplayName("Cash Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshClrSys")]
    #endif
    [IsoXmlTag("CshClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 
    #else
    public CashSettlementSystem4Choice_? CashClearingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_R7dXXzqEEeWVrPy0StzzSg")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType16Choice_? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType16Choice_? ExposureType { get; init; } 
    #else
    public ExposureType16Choice_? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [IsoId("_R7dXYzqEEeWVrPy0StzzSg")]
    [DisplayName("FX Standing Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxStgInstr")]
    #endif
    [IsoXmlTag("FxStgInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; } 
    #else
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_R7dXZzqEEeWVrPy0StzzSg")]
    [DisplayName("Market Client Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClntSd")]
    #endif
    [IsoXmlTag("MktClntSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketClientSide4Choice_? MarketClientSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClientSide4Choice_? MarketClientSide { get; init; } 
    #else
    public MarketClientSide4Choice_? MarketClientSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_R7dXazqEEeWVrPy0StzzSg")]
    [DisplayName("Netting Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgElgblty")]
    #endif
    [IsoXmlTag("NetgElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NettingEligibility4Choice_? NettingEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingEligibility4Choice_? NettingEligibility { get; init; } 
    #else
    public NettingEligibility4Choice_? NettingEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_R7dXbzqEEeWVrPy0StzzSg")]
    [DisplayName("Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regn")]
    #endif
    [IsoXmlTag("Regn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Registration9Choice_? Registration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Registration9Choice_? Registration { get; init; } 
    #else
    public Registration9Choice_? Registration { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_R7dXczqEEeWVrPy0StzzSg")]
    [DisplayName("Legal Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRstrctns")]
    #endif
    [IsoXmlTag("LglRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction5Choice_? LegalRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction5Choice_? LegalRestrictions { get; init; } 
    #else
    public Restriction5Choice_? LegalRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_R7dXdzqEEeWVrPy0StzzSg")]
    [DisplayName("Settling Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlgCpcty")]
    #endif
    [IsoXmlTag("SttlgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; } 
    #else
    public SettlingCapacity7Choice_? SettlingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_R7dXezqEEeWVrPy0StzzSg")]
    [DisplayName("Tax Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCpcty")]
    #endif
    [IsoXmlTag("TaxCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; } 
    #else
    public TaxCapacityParty4Choice_? TaxCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_R7dXfzqEEeWVrPy0StzzSg")]
    [DisplayName("Stamp Duty Tax Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyTaxBsis")]
    #endif
    [IsoXmlTag("StmpDtyTaxBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    #else
    public GenericIdentification30? StampDutyTaxBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [IsoId("_R7dXgzqEEeWVrPy0StzzSg")]
    [DisplayName("Tracking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trckg")]
    #endif
    [IsoXmlTag("Trckg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tracking4Choice_? Tracking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tracking4Choice_? Tracking { get; init; } 
    #else
    public Tracking4Choice_? Tracking { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_R7dXhzqEEeWVrPy0StzzSg")]
    [DisplayName("Letter Of Guarantee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfGrnt")]
    #endif
    [IsoXmlTag("LttrOfGrnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; } 
    #else
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [IsoId("_R7dXizqEEeWVrPy0StzzSg")]
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
    [IsoId("_R7dXjzqEEeWVrPy0StzzSg")]
    [DisplayName("Modification Cancellation Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCxlAllwd")]
    #endif
    [IsoXmlTag("ModCxlAllwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; } 
    #else
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_R7dXkzqEEeWVrPy0StzzSg")]
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
    [IsoId("_R7dXlzqEEeWVrPy0StzzSg")]
    [DisplayName("Securities Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSubBalTp")]
    #endif
    [IsoXmlTag("SctiesSubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    #else
    public GenericIdentification30? SecuritiesSubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_R7dXmTqEEeWVrPy0StzzSg")]
    [DisplayName("Cash Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSubBalTp")]
    #endif
    [IsoXmlTag("CshSubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    #else
    public GenericIdentification30? CashSubBalanceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
