// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of one or several keys of the request.
/// </summary>
[IsoId("_SuwKFgEcEeCQm6a_G2yO_w_-1482671344")]
[DisplayName("Request Details")]
public partial record RequestDetails4
{
    #nullable enable
    
    /// <summary>
    /// Key for which the specific data is returned, for example, a BIC.
    /// </summary>
    [IsoId("_SuwKFwEcEeCQm6a_G2yO_w_1787384874")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Key { get; init; } 
    
    /// <summary>
    /// Data being returned.
    /// </summary>
    [IsoId("_SuwKGAEcEeCQm6a_G2yO_w_-56014594")]
    [DisplayName("Report Data")]
    [IsoXmlTag("RptData")]
    public ReportParameter1? ReportData { get; init; } 
    
    
    #nullable disable
    
}
