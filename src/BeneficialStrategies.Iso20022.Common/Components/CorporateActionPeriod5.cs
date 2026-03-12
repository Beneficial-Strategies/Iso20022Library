// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods related to a corporate action option.
/// </summary>
[IsoId("_TY_6INp-Ed-ak6NoX_4Aeg_1716880031")]
[DisplayName("Corporate Action Period")]
public partial record CorporateActionPeriod5
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_TY_6Idp-Ed-ak6NoX_4Aeg_1716880050")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period1Choice_? PriceCalculationPeriod { get; init; } 
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_TY_6Itp-Ed-ak6NoX_4Aeg_1716880126")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period1Choice_? ParallelTradingPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_TY_6I9p-Ed-ak6NoX_4Aeg_1717800123")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period1Choice_? ActionPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    [IsoId("_TY_6JNp-Ed-ak6NoX_4Aeg_1717800140")]
    [DisplayName("Revocability Period")]
    [IsoXmlTag("RvcbltyPrd")]
    public Period1Choice_? RevocabilityPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the privilege is not available, for example, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    [IsoId("_TY_6Jdp-Ed-ak6NoX_4Aeg_1717803086")]
    [DisplayName("Privilege Suspension Period")]
    [IsoXmlTag("PrvlgSspnsnPrd")]
    public Period1Choice_? PrivilegeSuspensionPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the participant of the account servicer can revoke change or withdraw its instructions.
    /// </summary>
    [IsoId("_TY_6Jtp-Ed-ak6NoX_4Aeg_-1457682656")]
    [DisplayName("Account Servicer Revocability Period")]
    [IsoXmlTag("AcctSvcrRvcbltyPrd")]
    public Period1Choice_? AccountServicerRevocabilityPeriod { get; init; } 
    
    /// <summary>
    /// Period defining the last date on which withdrawal in street name requests on the outturn security will be accepted and the date on which the suspension will be released and withdrawal by transfer processing on the outturn security will resume.
    /// </summary>
    [IsoId("_TY_6J9p-Ed-ak6NoX_4Aeg_-1101202773")]
    [DisplayName("Depository Suspension Period For Withdrawal")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwl")]
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; } 
    
    
    #nullable disable
    
}
