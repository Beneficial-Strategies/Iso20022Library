// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on business day information.
/// </summary>
[IsoId("_wq9RhZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Business Day")]
public partial record BusinessDay6
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular market infrastructure.
    /// </summary>
    [IsoId("_wy9-A5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public ValueList<SystemIdentification2Choice_> SystemIdentification { get; init; } = [];
    // ID for the above is _wy9-A5lcEeeE1Ya-LgRsuQ
    
    /// <summary>
    /// Requested information on the system availability for a specific business day or business error when information has not been found.
    /// </summary>
    [IsoId("_wy9-BZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Or Error")]
    [IsoXmlTag("BizDayOrErr")]
    public required BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; } 
    
    
    #nullable disable
    
}
