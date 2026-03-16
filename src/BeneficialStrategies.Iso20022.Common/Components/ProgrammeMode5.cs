// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Programme Mode5.
/// </summary>
[IsoId("_QlWS8XjMEe6YlIMyoxWMJA")]
[DisplayName("Programme Mode5")]
public record ProgrammeMode5
{
    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<AdditionalData1> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Applied Identification.
    /// </summary>
    [DisplayName("Applied Identification")]
    [IsoXmlTag("ApldId")]
    public required IsoMax35Text AppliedIdentification { get; init; }
}
