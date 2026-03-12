// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on a member or a business error.
/// </summary>
[IsoId("_jmCflXSbEeiH1ZOt2UD8vQ")]
[DisplayName("Member Report")]
public partial record MemberReport5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_j3hRIXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    [IsoId("_j3hRI3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Or Error")]
    [IsoXmlTag("MmbOrErr")]
    public required MemberReportOrError6Choice_ MemberOrError { get; init; } 
    
    
    #nullable disable
    
}
