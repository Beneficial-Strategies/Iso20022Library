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
[IsoId("_Nt3jYeENEd-qUMZtd_eZuQ")]
[DisplayName("Corporate Action Period")]
public partial record CorporateActionPeriod7
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_Nt3jY-ENEd-qUMZtd_eZuQ")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period3Choice_? PriceCalculationPeriod { get; init; } 
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_Nt3jZeENEd-qUMZtd_eZuQ")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period3Choice_? ParallelTradingPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_Nt3jZ-ENEd-qUMZtd_eZuQ")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period3Choice_? ActionPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    [IsoId("_Nt3jaeENEd-qUMZtd_eZuQ")]
    [DisplayName("Revocability Period")]
    [IsoXmlTag("RvcbltyPrd")]
    public Period3Choice_? RevocabilityPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the privilege is not available, for example, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    [IsoId("_Nt3ja-ENEd-qUMZtd_eZuQ")]
    [DisplayName("Privilege Suspension Period")]
    [IsoXmlTag("PrvlgSspnsnPrd")]
    public Period3Choice_? PrivilegeSuspensionPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the participant of the account servicer can revoke change or withdraw its instructions.
    /// </summary>
    [IsoId("_Nt3jbeENEd-qUMZtd_eZuQ")]
    [DisplayName("Account Servicer Revocability Period")]
    [IsoXmlTag("AcctSvcrRvcbltyPrd")]
    public Period3Choice_? AccountServicerRevocabilityPeriod { get; init; } 
    
    /// <summary>
    /// Period defining the last date on which withdrawal in street name requests on the outturn security will be accepted and the date on which the suspension will be released and withdrawal by transfer processing on the outturn security will resume.
    /// </summary>
    [IsoId("_Nt3jb-ENEd-qUMZtd_eZuQ")]
    [DisplayName("Depository Suspension Period For Withdrawal")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwl")]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; } 
    
    
    #nullable disable
    
}
