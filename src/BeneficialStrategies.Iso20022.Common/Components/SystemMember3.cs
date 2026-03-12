// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about a system and about a member of a system.
/// </summary>
[IsoId("_htb_MXSbEeiH1ZOt2UD8vQ")]
[DisplayName("System Member")]
public partial record SystemMember3
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_h_8rgXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_h_8rg3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    
    
    #nullable disable
    
}
