// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance types related to an unallocated redemption payment.
/// </summary>
[IsoId("_V1OIGqJGEeS6IulNYwkZBg")]
[DisplayName("Corporate Action Unallocated Balance SD")]
public partial record CorporateActionUnallocatedBalanceSD1
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_V1OILKJGEeS6IulNYwkZBg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat4? TotalEligibleBalance { get; init; } 
    
    /// <summary>
    /// The quantity that has been determined to be redeemed if the participant had
    /// position in a redemption security.
    /// </summary>
    [IsoId("_V1OIKqJGEeS6IulNYwkZBg")]
    [DisplayName("Affected Balance")]
    [IsoXmlTag("AfctdBal")]
    public SignedQuantityFormat4? AffectedBalance { get; init; } 
    
    /// <summary>
    /// Positions balance remaining after lottery is run.
    /// </summary>
    [IsoId("_V1OIPqJGEeS6IulNYwkZBg")]
    [DisplayName("Unaffected Balance")]
    [IsoXmlTag("UafctdBal")]
    public SignedQuantityFormat4? UnaffectedBalance { get; init; } 
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfill their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_V1OIM6JGEeS6IulNYwkZBg")]
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat4? ObligatedBalance { get; init; } 
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_V1OINaJGEeS6IulNYwkZBg")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat4? OriginalBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_V1OIKaJGEeS6IulNYwkZBg")]
    [DisplayName("Pledged Balance")]
    [IsoXmlTag("PldgdBal")]
    public SignedQuantityFormat4? PledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_V1OIK6JGEeS6IulNYwkZBg")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat4? UnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_V1OINKJGEeS6IulNYwkZBg")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat4? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_V1OINqJGEeS6IulNYwkZBg")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat4? InvestmentUnpledgedBalance { get; init; } 
    
    
    #nullable disable
    
}
