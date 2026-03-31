// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on a member or a business error.
/// </summary>
[IsoId("_i0a-VZlCEee-Zps0fZQaFQ")]
[DisplayName("Member Report")]
public record MemberReport4
{
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_i8mp8ZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public required MemberIdentification2Choice_ MemberIdentification { get; init; }

    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    [IsoId("_i8mp85lCEee-Zps0fZQaFQ")]
    [DisplayName("Member Or Error")]
    [IsoXmlTag("MmbOrErr")]
    public required MemberReportOrError4Choice_ MemberOrError { get; init; }
}
