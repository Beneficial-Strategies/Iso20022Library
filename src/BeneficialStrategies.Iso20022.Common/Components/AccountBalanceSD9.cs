// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_qOfHUZFCEeanIpS4qvJ1tw")]
[DisplayName("Account Balance SD")]
public partial record AccountBalanceSD9
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_qrWpgZFCEeanIpS4qvJ1tw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_qrWpg5FCEeanIpS4qvJ1tw")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_qrWphZFCEeanIpS4qvJ1tw")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_qrWph5FCEeanIpS4qvJ1tw")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_qrWpiZFCEeanIpS4qvJ1tw")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// Balance that has been accepted by the issuer / agent for payment.
    /// </summary>
    [IsoId("_J_zj4JFDEeanIpS4qvJ1tw")]
    [DisplayName("Accepted Balance")]
    [IsoXmlTag("AccptdBal")]
    public SignedQuantityFormat9? AcceptedBalance { get; init; } 
    
    /// <summary>
    /// Balance that has not been accepted by issuer / agent for payment.
    /// </summary>
    [IsoId("_WFJlEJFDEeanIpS4qvJ1tw")]
    [DisplayName("Unaccepted Balance")]
    [IsoXmlTag("UaccptdBal")]
    public SignedQuantityFormat9? UnacceptedBalance { get; init; } 
    
    /// <summary>
    /// For Rights Subscription events, total number of oversubscribed units applicable to the payment or the subscription charge.
    /// </summary>
    [IsoId("_hNyGYJFDEeanIpS4qvJ1tw")]
    [DisplayName("Oversubscription Balance")]
    [IsoXmlTag("OvrsbcptBal")]
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; } 
    
    
    #nullable disable
    
}
