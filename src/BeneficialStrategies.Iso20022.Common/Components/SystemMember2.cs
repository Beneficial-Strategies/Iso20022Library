// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about a system and about a member of a system.
/// </summary>
[IsoId("_78fiFaMgEeCJ6YNENx4h-w_-1952044012")]
[DisplayName("System Member")]
public record SystemMember2
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_78fiFqMgEeCJ6YNENx4h-w_-944964888")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_78fiF6MgEeCJ6YNENx4h-w_963171998")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public required MemberIdentification2Choice_ MemberIdentification { get; init; }
}
