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
[IsoId("_7JKuIecXEei5aPS232E3Mw")]
[DisplayName("Account Balance SD")]
public partial record AccountBalanceSD14
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_7xerUecXEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_7xerU-cXEei5aPS232E3Mw")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC general free account as of day prior to publication date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_7xerVecXEei5aPS232E3Mw")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC segregated account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_7xerV-cXEei5aPS232E3Mw")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC investment account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_7xerWecXEei5aPS232E3Mw")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// For rights subscription events, total number of oversubscribed units applicable to the payment or the subscription charge.
    /// </summary>
    [IsoId("_7xerX-cXEei5aPS232E3Mw")]
    [DisplayName("Oversubscription Balance")]
    [IsoXmlTag("OvrsbcptBal")]
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; } 
    
    
    #nullable disable
    
}
