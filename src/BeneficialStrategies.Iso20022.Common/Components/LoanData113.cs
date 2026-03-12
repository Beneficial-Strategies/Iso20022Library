// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction.
/// </summary>
[IsoId("_dV4cqWuAEeuBFr93I_HBig")]
[DisplayName("Loan Data")]
public partial record LoanData113
{
    #nullable enable
    
    /// <summary>
    /// Unique reference assigned to the transaction to identify the trade.
    /// </summary>
    [IsoId("_dXyhIWuAEeuBFr93I_HBig")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_dXyhI2uAEeuBFr93I_HBig")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; } 
    
    /// <summary>
    /// Market value of the securities or commodities on loan or borrowed.
    /// </summary>
    [IsoId("_dXyhJWuAEeuBFr93I_HBig")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required AmountAndDirection53 MarketValue { get; init; } 
    
    
    #nullable disable
    
}
