// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report of the requested data.
/// </summary>
[IsoId("_SumZGwEcEeCQm6a_G2yO_w_1103821784")]
[DisplayName("Request Details")]
public partial record RequestDetails5
{
    #nullable enable
    
    /// <summary>
    /// Type of data requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_SuwKEAEcEeCQm6a_G2yO_w_1937892344")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Reference to the request for which the report is sent.
    /// </summary>
    [IsoId("_SuwKEQEcEeCQm6a_G2yO_w_-179622077")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RequestReference { get; init; } 
    
    /// <summary>
    /// Report key and returned data.
    /// </summary>
    [IsoId("_SuwKEgEcEeCQm6a_G2yO_w_1731831000")]
    [DisplayName("Report Key")]
    [IsoXmlTag("RptKey")]
    public ValueList<RequestDetails4> ReportKey { get; init; } = [];
    // ID for the above is _SuwKEgEcEeCQm6a_G2yO_w_1731831000
    
    
    #nullable disable
    
}
