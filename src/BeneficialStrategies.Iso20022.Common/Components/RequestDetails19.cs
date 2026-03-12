// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the processing request.
/// </summary>
[IsoId("_qWuLAZXcEeaYkf5FCqYMeA")]
[DisplayName("Request Details")]
public partial record RequestDetails19
{
    #nullable enable
    
    /// <summary>
    /// Type of data being requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_qh5gQZXcEeaYkf5FCqYMeA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Identificates the requestor.
    /// </summary>
    [IsoId("_qh5gQ5XcEeaYkf5FCqYMeA")]
    [DisplayName("Requestor Identification")]
    [IsoXmlTag("RqstrId")]
    public PartyIdentification73Choice_? RequestorIdentification { get; init; } 
    
    /// <summary>
    /// Additional information to support the processing request.
    /// </summary>
    [IsoId("_gaPZ0JwpEeahw7LV9elg3w")]
    [DisplayName("Additional Request Information")]
    [IsoXmlTag("AddtlReqInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalRequestInformation { get; init; } 
    
    
    #nullable disable
    
}
