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
/// Specifies periods of a corporate action.
/// </summary>
[IsoId("_TZlwBdp-Ed-ak6NoX_4Aeg_635105711")]
[DisplayName("Corporate Action Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriod3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_TZlwBtp-Ed-ak6NoX_4Aeg_643414438")]
    [DisplayName("Price Calculation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricClctnPrd")]
    #endif
    [IsoXmlTag("PricClctnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? PriceCalculationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? PriceCalculationPeriod { get; init; } 
    #else
    public Period1Choice_? PriceCalculationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_TZlwB9p-Ed-ak6NoX_4Aeg_635106185")]
    [DisplayName("Interest Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPrd")]
    #endif
    [IsoXmlTag("IntrstPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? InterestPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? InterestPeriod { get; init; } 
    #else
    public Period1Choice_? InterestPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [IsoId("_TZvhANp-Ed-ak6NoX_4Aeg_635106125")]
    [DisplayName("Compulsory Purchase Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmplsryPurchsPrd")]
    #endif
    [IsoXmlTag("CmplsryPurchsPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? CompulsoryPurchasePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? CompulsoryPurchasePeriod { get; init; } 
    #else
    public Period1Choice_? CompulsoryPurchasePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the security is blocked.
    /// </summary>
    [IsoId("_TZvhAdp-Ed-ak6NoX_4Aeg_635105796")]
    [DisplayName("Blocking Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckgPrd")]
    #endif
    [IsoXmlTag("BlckgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? BlockingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? BlockingPeriod { get; init; } 
    #else
    public Period1Choice_? BlockingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period assigned by the court in a class action. It determines the client&apos;s eligible transactions that will be included in the class action and used to determine the resulting entitlement.
    /// </summary>
    [IsoId("_TZvhAtp-Ed-ak6NoX_4Aeg_1015593443")]
    [DisplayName("Claim Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClmPrd")]
    #endif
    [IsoXmlTag("ClmPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? ClaimPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? ClaimPeriod { get; init; } 
    #else
    public Period1Choice_? ClaimPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which book entry transfers will be accepted and the date on which the suspension will be released and book entry transfer processing will resume.
    /// </summary>
    [IsoId("_TZvhA9p-Ed-ak6NoX_4Aeg_1077194615")]
    [DisplayName("Depository Suspension Period For Book Entry Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForBookNtryTrf")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForBookNtryTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which deposits, into nominee name, at the agent will be accepted and the date on which the suspension will be released and deposits at agent will resume.
    /// </summary>
    [IsoId("_TZvhBNp-Ed-ak6NoX_4Aeg_1407816466")]
    [DisplayName("Depository Suspension Period For Deposit At Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForDpstAtAgt")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForDpstAtAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which deposits will be accepted and the date on which the suspension will be released and deposits will resume.
    /// </summary>
    [IsoId("_TZvhBdp-Ed-ak6NoX_4Aeg_1463228591")]
    [DisplayName("Depository Suspension Period For Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForDpst")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForDeposit { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which pledges will be accepted and the date on which the suspension will be released and pledge processing will resume.
    /// </summary>
    [IsoId("_TZvhBtp-Ed-ak6NoX_4Aeg_1519561963")]
    [DisplayName("Depository Suspension Period For Pledge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForPldg")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForPldg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForPledge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForPledge { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForPledge { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which intra-position balances can be segregated and the date on which the suspension will be released and the ability to segregate intra-position balances will resume.
    /// </summary>
    [IsoId("_TZvhB9p-Ed-ak6NoX_4Aeg_1647006341")]
    [DisplayName("Depository Suspension Period For Segregation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForSgrtn")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForSgrtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForSegregation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForSegregation { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForSegregation { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which withdrawals, from nominee name at the agent will be accepted and the date on which the suspension will be released and withdrawals at agent processing will resume.
    /// </summary>
    [IsoId("_TZvhCNp-Ed-ak6NoX_4Aeg_1924064084")]
    [DisplayName("Depository Suspension Period For Withdrawal At Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForWdrwlAtAgt")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlAtAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date for which physical withdrawals in the nominee&apos;s name will be accepted and the date on which the suspension will be released and physical withdrawals in the nominee&apos;s name will resume.
    /// </summary>
    [IsoId("_TZvhCdp-Ed-ak6NoX_4Aeg_1997946852")]
    [DisplayName("Depository Suspension Period For Withdrawal In Nominee Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForWdrwlInNmneeNm")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInNmneeNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date on which withdrawal requests in street name&apos;s will be accepted on the event security and the date on which the suspension will be released and withdrawal in street name&apos;s processing on the event security will resume.
    /// </summary>
    [IsoId("_TZ4q8Np-Ed-ak6NoX_4Aeg_-2002418252")]
    [DisplayName("Depository Suspension Period For Withdrawal In Street Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstrySspnsnPrdForWdrwlInStrtNm")]
    #endif
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInStrtNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; } 
    #else
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date on which shareholder registration will be accepted by the issuer and the date on which shareholder registration will resume.
    /// </summary>
    [IsoId("_TZ4q8dp-Ed-ak6NoX_4Aeg_91986466")]
    [DisplayName("Book Closure Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookClsrPrd")]
    #endif
    [IsoXmlTag("BookClsrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1Choice_? BookClosurePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1Choice_? BookClosurePeriod { get; init; } 
    #else
    public Period1Choice_? BookClosurePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
