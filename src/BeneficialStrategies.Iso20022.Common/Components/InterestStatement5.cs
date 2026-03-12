// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the interest statement.
/// </summary>
[IsoId("_WxUNESqWEeyR9JrVGfaMKw")]
[DisplayName("Interest Statement")]
public partial record InterestStatement5
{
    #nullable enable
    
    /// <summary>
    /// Provides the period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_Xfp5wSqWEeyR9JrVGfaMKw")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public required DatePeriod2 InterestPeriod { get; init; } 
    
    /// <summary>
    /// Provides the total amount of interest that is due to partyA.
    /// </summary>
    [IsoId("_Xfp5wyqWEeyR9JrVGfaMKw")]
    [DisplayName("Total Interest Amount Due To A")]
    [IsoXmlTag("TtlIntrstAmtDueToA")]
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; init; } 
    
    /// <summary>
    /// Provides the total amount of interest that is due to partyB.
    /// </summary>
    [IsoId("_Xfp5xSqWEeyR9JrVGfaMKw")]
    [DisplayName("Total Interest Amount Due To B")]
    [IsoXmlTag("TtlIntrstAmtDueToB")]
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; init; } 
    
    /// <summary>
    /// Indicates the value date of the interest statement.
    /// </summary>
    [IsoId("_Xfp5xyqWEeyR9JrVGfaMKw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_Xfp5ySqWEeyR9JrVGfaMKw")]
    [DisplayName("Interest Payment Request Identification")]
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InterestPaymentRequestIdentification { get; init; } 
    
    /// <summary>
    /// Provides the details of the interest calculation.
    /// </summary>
    [IsoId("_Xfp5yyqWEeyR9JrVGfaMKw")]
    [DisplayName("Interest Calculation")]
    [IsoXmlTag("IntrstClctn")]
    public InterestCalculation5? InterestCalculation { get; init; } 
    
    
    #nullable disable
    
}
