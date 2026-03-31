// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference Data1.
/// </summary>
[IsoId("_e_ODIbMbEe-OHY85tcOC5w")]
[DisplayName("Reference Data1")]
public record ReferenceData1
{
    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required ReferenceDataEnvelope1 Data { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax350Text? Type { get; init; }
}
