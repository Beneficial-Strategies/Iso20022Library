// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related Investigation Data1.
/// </summary>
[IsoId("_CXmpUFRtEe23M4WgERMsYw")]
[DisplayName("Related Investigation Data1")]
public record RelatedInvestigationData1
{
    /// <summary>
    /// Investigation Identification.
    /// </summary>
    [DisplayName("Investigation Identification")]
    [IsoXmlTag("InvstgtnId")]
    public IsoMax35Text? InvestigationIdentification { get; init; }

    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public ValueList<InvestigationLocationData1> Location { get; init; } = [];
}
