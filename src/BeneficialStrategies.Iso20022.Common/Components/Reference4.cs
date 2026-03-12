// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote cancellation.
/// </summary>
[IsoId("_Q_XJQtp-Ed-ak6NoX_4Aeg_977068732")]
[DisplayName("Reference")]
public partial record Reference4
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_XJQ9p-Ed-ak6NoX_4Aeg_1362176270")]
    [DisplayName("Quote Request Identification")]
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    [IsoId("_Q_XJRNp-Ed-ak6NoX_4Aeg_1364948446")]
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteIdentification { get; init; } 
    
    
    #nullable disable
    
}
