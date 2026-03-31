// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Date26.
/// </summary>
[IsoId("_Ur-Z8XSdEe6VWZz2tTgENw")]
[DisplayName("Security Date26")]
public record SecurityDate26
{
    /// <summary>
    /// Available Date.
    /// </summary>
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat41Choice_? AvailableDate { get; init; }

    /// <summary>
    /// Dividend Ranking Date.
    /// </summary>
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat41Choice_? DividendRankingDate { get; init; }

    /// <summary>
    /// Earliest Payment Date.
    /// </summary>
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat41Choice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Pari Passu Date.
    /// </summary>
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat41Choice_? PariPassuDate { get; init; }

    /// <summary>
    /// Payment Date.
    /// </summary>
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat41Choice_? PaymentDate { get; init; }

    /// <summary>
    /// Posting Date.
    /// </summary>
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTime2Choice_ PostingDate { get; init; }
}
