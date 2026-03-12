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
[IsoId("_doTs95EhEeajS_7NioJdVA")]
[DisplayName("Account Balance SD")]
public partial record AccountBalanceSD8
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_doTs-ZEhEeajS_7NioJdVA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Balance of all uncovered protect instructions across all options.
    /// </summary>
    [IsoId("_doTs-pEhEeajS_7NioJdVA")]
    [DisplayName("Uncovered Protect Balance")]
    [IsoXmlTag("UcvrdPrtctBal")]
    public SignedQuantityFormat9? UncoveredProtectBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_doTs_ZEhEeajS_7NioJdVA")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_doTs-JEhEeajS_7NioJdVA")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    
    /// <summary>
    /// Position held in DTC memo segregated account. This position is eligible for payment.
    /// </summary>
    [IsoId("_doTs-5EhEeajS_7NioJdVA")]
    [DisplayName("Memo Segregation Balance")]
    [IsoXmlTag("MemoSgrtnBal")]
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    
    
    #nullable disable
    
}
