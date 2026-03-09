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
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_ZdqPNffXEeiNZp_PtLohLw")]
[DisplayName("Securities Financing Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingTransactionDetails50
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_ZdqPOffXEeiNZp_PtLohLw")]
    [DisplayName("Securities Financing Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgTradId")]
    #endif
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax52Text? SecuritiesFinancingTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesFinancingTradeIdentification { get; init; } 
    #else
    public System.String? SecuritiesFinancingTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_ZdqPQffXEeiNZp_PtLohLw")]
    [DisplayName("Closing Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgLegId")]
    #endif
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingLegIdentification { get; init; } 
    #else
    public System.String? ClosingLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_ZdqPSffXEeiNZp_PtLohLw")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminationDate7Choice_? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminationDate7Choice_? TerminationDate { get; init; } 
    #else
    public TerminationDate7Choice_? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_ZdqPUffXEeiNZp_PtLohLw")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateType67Choice_? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType67Choice_? RateType { get; init; } 
    #else
    public RateType67Choice_? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_ZdqPWffXEeiNZp_PtLohLw")]
    [DisplayName("Legal Framework")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglFrmwk")]
    #endif
    [IsoXmlTag("LglFrmwk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    #else
    public LegalFramework4Choice_? LegalFramework { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_ZdqPYffXEeiNZp_PtLohLw")]
    [DisplayName("Maturity Date Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDtMod")]
    #endif
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaturityDateModification { get; init; } 
    #else
    public System.String? MaturityDateModification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_ZdqPaffXEeiNZp_PtLohLw")]
    [DisplayName("Interest Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmt")]
    #endif
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestPayment { get; init; } 
    #else
    public System.String? InterestPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_ZdqPcffXEeiNZp_PtLohLw")]
    [DisplayName("Variable Rate Support")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateSpprt")]
    #endif
    [IsoXmlTag("VarblRateSpprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateName2? VariableRateSupport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateName2? VariableRateSupport { get; init; } 
    #else
    public RateName2? VariableRateSupport { get; set; } 
    #endif
    
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_ZdqPeffXEeiNZp_PtLohLw")]
    [DisplayName("Repurchase Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpRate")]
    #endif
    [IsoXmlTag("RpRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? RepurchaseRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? RepurchaseRate { get; init; } 
    #else
    public Rate2? RepurchaseRate { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_ZdqPgffXEeiNZp_PtLohLw")]
    [DisplayName("Transaction Call Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCallDely")]
    #endif
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionCallDelay { get; init; } 
    #else
    public System.String? TransactionCallDelay { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_ZdqPiffXEeiNZp_PtLohLw")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection59? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_ZdqPkffXEeiNZp_PtLohLw")]
    [DisplayName("Termination Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnTxAmt")]
    #endif
    [IsoXmlTag("TermntnTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    #else
    public AmountAndDirection59? TerminationTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_ZdqPmffXEeiNZp_PtLohLw")]
    [DisplayName("Second Leg Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLegNrrtv")]
    #endif
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondLegNarrative { get; init; } 
    #else
    public System.String? SecondLegNarrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
