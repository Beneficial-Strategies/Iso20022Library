// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the type of investors in relation to a corporate action.
/// </summary>
[IsoId("_ki8AAKnUEfC5VNwixU6YfQ")]
[DisplayName("Investor Type Identification1")]
public record InvestorTypeIdentification1
{
    /// <summary>
    /// Types of investor in relation to a corporate event.
    /// </summary>
    [IsoId("_aksfwK5qEfCUHaCK5HWOhg")]
    [DisplayName("Investor Type Identification")]
    [IsoXmlTag("InvstrTpId")]
    public required InvestorClassificationType1Code InvestorTypeIdentification { get; init; }

    /// <summary>
    /// Information about the investor type identification.
    /// </summary>
    [IsoId("_gxL3MK5qEfCUHaCK5HWOhg")]
    [DisplayName("Investor Type Identification Narrative")]
    [IsoXmlTag("InvstrTpIdNrrtv")]
    public IsoMax1025Text? InvestorTypeIdentificationNarrative { get; init; }
}
