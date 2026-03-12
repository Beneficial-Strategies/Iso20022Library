// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the margin call, that is a description and a response type.
/// </summary>
[IsoId("_QnYHEdp-Ed-ak6NoX_4Aeg_596730700")]
[DisplayName("Response")]
public partial record Response1
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the response type.
    /// </summary>
    [IsoId("_QnYHEtp-Ed-ak6NoX_4Aeg_-119884462")]
    [DisplayName("Response Type Details")]
    [IsoXmlTag("RspnTpDtls")]
    public ValueList<ResponseType1Choice_> ResponseTypeDetails { get; init; } = new ValueList<ResponseType1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _QnYHEtp-Ed-ak6NoX_4Aeg_-119884462
    
    /// <summary>
    /// Provides additional details related to the margin call response.
    /// </summary>
    [IsoId("_QnYHE9p-Ed-ak6NoX_4Aeg_719911987")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
