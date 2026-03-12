// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security date details.
/// </summary>
[IsoId("_8Ke6HTQIEe2o-K1dwNg8Gg")]
[DisplayName("Security Date")]
public partial record SecurityDate20
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_8jq1szQIEe2o-K1dwNg8Gg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat30Choice_ PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_8jq1uzQIEe2o-K1dwNg8Gg")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat30Choice_? AvailableDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_8jq1wzQIEe2o-K1dwNg8Gg")]
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat30Choice_? DividendRankingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_8jq1yzQIEe2o-K1dwNg8Gg")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat30Choice_? EarliestPaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_8jq10zQIEe2o-K1dwNg8Gg")]
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat30Choice_? PariPassuDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the securities to be reorganised will cease to be tradeable.
    /// </summary>
    [IsoId("_8jq12zQIEe2o-K1dwNg8Gg")]
    [DisplayName("Last Trading Date")]
    [IsoXmlTag("LastTradgDt")]
    public DateFormat30Choice_? LastTradingDate { get; init; } 
    
    
    #nullable disable
    
}
