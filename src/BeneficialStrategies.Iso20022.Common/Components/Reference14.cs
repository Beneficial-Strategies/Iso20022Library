// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the cross order modification request.
/// </summary>
[IsoId("_RAGwItp-Ed-ak6NoX_4Aeg_1808035422")]
[DisplayName("Reference")]
public partial record Reference14
{
    #nullable enable
    
    /// <summary>
    /// Cross Identification of the previous cross order (not the initial cross order of the day) as assigned by the institution, used to identify the previous cross order in CrossOrderModificationRequest.
    /// </summary>
    [IsoId("_RAGwI9p-Ed-ak6NoX_4Aeg_1644227031")]
    [DisplayName("Original Cross Order Identification")]
    [IsoXmlTag("OrgnlCrossOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalCrossOrderIdentification { get; init; } 
    
    /// <summary>
    /// Host assigned entity identification that can be used to reference all components of a cross; sides + strategy + legs. Used as the primary key with which to refer to the cross order for modification. The HostCrossId will also be used to link together components of the Cross Order. For example, each individual Notice of Execution associated with the order will carry HostCrossID in order to tie back to the original cross order.
    /// </summary>
    [IsoId("_RAGwJNp-Ed-ak6NoX_4Aeg_69360388")]
    [DisplayName("Host Cross Identification")]
    [IsoXmlTag("HstCrossId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostCrossIdentification { get; init; } 
    
    
    #nullable disable
    
}
