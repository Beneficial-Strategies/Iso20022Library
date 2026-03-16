// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging provides summary information about lodging accommodations and related expenses for the cardholder.
/// </summary>
[IsoId("_SiW0AcWmEeuhguwJmlgagQ")]
[DisplayName("Lodging")]
public record Lodging3
{
    /// <summary>
    /// Component provides summary information about lodging accommodations and related expenses for the cardholder. One occurrence of this component provides lodging accommodation reporting for a single lodging folio, such as a single stay at a lodging facility with one check-in and one check-out.
    /// </summary>
    [IsoId("_Sm2SccWmEeuhguwJmlgagQ")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public LodgingSummary2? Summary { get; init; }

    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder. Acquirers can submit multiple occurrences of this component for each lodging transaction, to provide details of one or more folios.
    /// </summary>
    [IsoId("_Sm2Sc8WmEeuhguwJmlgagQ")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public LodgingLineItem2? LineItem { get; init; }
}
