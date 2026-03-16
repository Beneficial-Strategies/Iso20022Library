// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Date25.
/// </summary>
[IsoId("_T8MgUWKOEe6iKbrXdnOlfA")]
[DisplayName("Security Date25")]
public partial record SecurityDate25
{
    #nullable enable

    /// <summary>
    /// Available Date.
    /// </summary>
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat30Choice_? AvailableDate { get; init; } 

    /// <summary>
    /// Dividend Ranking Date.
    /// </summary>
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat30Choice_? DividendRankingDate { get; init; } 

    /// <summary>
    /// Earliest Payment Date.
    /// </summary>
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat30Choice_? EarliestPaymentDate { get; init; } 

    /// <summary>
    /// Pari Passu Date.
    /// </summary>
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat30Choice_? PariPassuDate { get; init; } 

    /// <summary>
    /// Payment Date.
    /// </summary>
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat30Choice_? PaymentDate { get; init; } 

    /// <summary>
    /// Posting Date.
    /// </summary>
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTime2Choice_ PostingDate { get; init; } 

    
    #nullable disable
    
}
