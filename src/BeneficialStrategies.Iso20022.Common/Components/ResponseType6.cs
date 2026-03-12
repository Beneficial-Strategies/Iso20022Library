// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[IsoId("_BGwWoY4YEeW6h7rGyYlyTg")]
[DisplayName("Response Type")]
public partial record ResponseType6
{
    #nullable enable
    
    /// <summary>
    /// Response of the terminal manager.
    /// </summary>
    [IsoId("_BRMFAY4YEeW6h7rGyYlyTg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response2Code Response { get; init; } 
    
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_BRMFA44YEeW6h7rGyYlyTg")]
    [DisplayName("Response Detail")]
    [IsoXmlTag("RspnDtl")]
    public ResultDetail3Code? ResponseDetail { get; init; } 
    
    /// <summary>
    /// Additional information on the response for further examination.
    /// </summary>
    [IsoId("_BRMFBY4YEeW6h7rGyYlyTg")]
    [DisplayName("Additional Response")]
    [IsoXmlTag("AddtlRspn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalResponse { get; init; } 
    
    
    #nullable disable
    
}
