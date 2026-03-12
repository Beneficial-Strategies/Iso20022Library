// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the cross order.
/// </summary>
[IsoId("_Q_9mMtp-Ed-ak6NoX_4Aeg_-383447742")]
[DisplayName("Reference")]
public partial record Reference11
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of indication of interest message. Required for previously indicated orders.
    /// </summary>
    [IsoId("_Q_9mM9p-Ed-ak6NoX_4Aeg_-237887873")]
    [DisplayName("IOI Identification")]
    [IsoXmlTag("IOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IOIIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote. Required for previously quoted orders.
    /// </summary>
    [IsoId("_Q_9mNNp-Ed-ak6NoX_4Aeg_8690812")]
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteIdentification { get; init; } 
    
    
    #nullable disable
    
}
