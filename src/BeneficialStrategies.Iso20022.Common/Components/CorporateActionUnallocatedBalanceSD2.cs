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
[IsoId("_Fdb8EJEvEeajS_7NioJdVA")]
[DisplayName("Corporate Action Unallocated Balance SD")]
public partial record CorporateActionUnallocatedBalanceSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_8t15MZEvEeajS_7NioJdVA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_Fdb8GJEvEeajS_7NioJdVA")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat9? TotalEligibleBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC Segregated account. This position is ineligible for payment until released from pledgee.
    /// </summary>
    [IsoId("_Fdb8EZEvEeajS_7NioJdVA")]
    [DisplayName("Pledged Balance")]
    [IsoXmlTag("PldgdBal")]
    public SignedQuantityFormat9? PledgedBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC Segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_Fdb8FZEvEeajS_7NioJdVA")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC Segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events. 
    /// </summary>
    [IsoId("_Fdb8H5EvEeajS_7NioJdVA")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC Segregated account. This position is eligible for payment.
    /// </summary>
    [IsoId("_1AWpEZEvEeajS_7NioJdVA")]
    [DisplayName("Memo Segregation Balance")]
    [IsoXmlTag("MemoSgrtnBal")]
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    
    
    #nullable disable
    
}
