// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the characteristics of a portfolio.
/// </summary>
[IsoId("_TUra39p-Ed-ak6NoX_4Aeg_208948486")]
[DisplayName("Portfolio")]
public partial record Portfolio1
{
    #nullable enable
    
    /// <summary>
    /// Additional information related to the portfolio.
    /// </summary>
    [IsoId("_TU0kwNp-Ed-ak6NoX_4Aeg_501703515")]
    [DisplayName("Portfolio Information")]
    [IsoXmlTag("PrtflInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> PortfolioInformation { get; init; } = [];
    
    
    #nullable disable
    
}
