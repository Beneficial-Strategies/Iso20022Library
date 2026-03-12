// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action balance details.
/// </summary>
[IsoId("_U6RS4GHAEeORiK3bBeBzGg")]
[DisplayName("Corporate Action Balance SD")]
public partial record CorporateActionBalanceSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_CEGBoWHBEeORiK3bBeBzGg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_oXrGxmHAEeORiK3bBeBzGg")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat4? OriginalBalance { get; init; } 
    
    /// <summary>
    /// Adjusted position held in a security that is subject to redemption call.
    /// </summary>
    [IsoId("_oXrGx2HAEeORiK3bBeBzGg")]
    [DisplayName("Adjusted Balance")]
    [IsoXmlTag("AdjstdBal")]
    public SignedQuantityFormat4? AdjustedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_oXrGyGHAEeORiK3bBeBzGg")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat4? UnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_oXrGymHAEeORiK3bBeBzGg")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat4? InvestmentUnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_oXrGy2HAEeORiK3bBeBzGg")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat4? InvestmentPledgedBalance { get; init; } 
    
    
    #nullable disable
    
}
