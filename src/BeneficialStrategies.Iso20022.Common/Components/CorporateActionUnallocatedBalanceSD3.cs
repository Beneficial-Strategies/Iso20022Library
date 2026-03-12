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
[IsoId("_QvgRnb-8Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Unallocated Balance SD")]
public partial record CorporateActionUnallocatedBalanceSD3
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_Q_IB4b-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat9? TotalEligibleBalance { get; init; } 
    
    /// <summary>
    /// The quantity that has been determined to be redeemed if the participant had
    /// position in a redemption security.
    /// </summary>
    [IsoId("_Q_IB77-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Affected Balance")]
    [IsoXmlTag("AfctdBal")]
    public SignedQuantityFormat9? AffectedBalance { get; init; } 
    
    /// <summary>
    /// Positions balance remaining after lottery is run.
    /// </summary>
    [IsoId("_Q_IB8b-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unaffected Balance")]
    [IsoXmlTag("UafctdBal")]
    public SignedQuantityFormat9? UnaffectedBalance { get; init; } 
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_Q_IB87-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat9? ObligatedBalance { get; init; } 
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_Q_IB9b-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC general free account as of day prior to publication date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_Q_IB97-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Pledged Balance")]
    [IsoXmlTag("PldgdBal")]
    public SignedQuantityFormat9? PledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC general free account as of day prior to publication date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_Q_IB-b-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC investment account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_Q_IB-7-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC segregated account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_Q_IB_b-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    
    
    #nullable disable
    
}
