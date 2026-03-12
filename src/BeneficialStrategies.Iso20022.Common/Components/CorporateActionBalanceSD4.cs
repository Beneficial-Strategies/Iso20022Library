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
[IsoId("_HxgcEb5ZEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Balance SD")]
public partial record CorporateActionBalanceSD4
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_IB3zUb5ZEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_IB3zU75ZEeexmbB7KsjCwA")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    
    /// <summary>
    /// Adjusted position held in a security that is subject to redemption call.
    /// </summary>
    [IsoId("_IB3zVb5ZEeexmbB7KsjCwA")]
    [DisplayName("Adjusted Balance")]
    [IsoXmlTag("AdjstdBal")]
    public SignedQuantityFormat9? AdjustedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC general free account as of day prior to publication date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_IB3zV75ZEeexmbB7KsjCwA")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC segregated account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_IB3zWb5ZEeexmbB7KsjCwA")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Portion of the original balance position held in DTC investment account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_IB3zW75ZEeexmbB7KsjCwA")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC segregated account. This position is eligible for payment.
    /// </summary>
    [IsoId("_IB3zXb5ZEeexmbB7KsjCwA")]
    [DisplayName("Memo Segregation Balance")]
    [IsoXmlTag("MemoSgrtnBal")]
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    
    
    #nullable disable
    
}
