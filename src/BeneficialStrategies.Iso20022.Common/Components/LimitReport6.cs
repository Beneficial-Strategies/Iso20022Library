// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the risk management limit or on a business error.
/// </summary>
[IsoId("_RDVxR5lhEeeE1Ya-LgRsuQ")]
[DisplayName("Limit Report")]
public partial record LimitReport6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the limit on which information is requested.
    /// </summary>
    [IsoId("_RRErQ5lhEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification1 LimitIdentification { get; init; } 
    
    /// <summary>
    /// Requested information on the limit or business error report when information has not been found.
    /// </summary>
    [IsoId("_RRErRZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Or Error")]
    [IsoXmlTag("LmtOrErr")]
    public required LimitOrError3Choice_ LimitOrError { get; init; } 
    
    
    #nullable disable
    
}
