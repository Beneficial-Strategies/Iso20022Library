// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
/// </summary>
[IsoId("_xhMHQa6XEees_ufOy2ci-g")]
[DisplayName("Pagination")]
public partial record Pagination1
{
    #nullable enable
    
    /// <summary>
    /// Page number.
    /// </summary>
    [IsoId("_xsy6Ua6XEees_ufOy2ci-g")]
    [DisplayName("Page Number")]
    [IsoXmlTag("PgNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public required IsoMax5NumericText PageNumber { get; init; } 
    
    /// <summary>
    /// Indicates the last page.
    /// </summary>
    [IsoId("_xsy6U66XEees_ufOy2ci-g")]
    [DisplayName("Last Page Indicator")]
    [IsoXmlTag("LastPgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator LastPageIndicator { get; init; } 
    
    
    #nullable disable
    
}
