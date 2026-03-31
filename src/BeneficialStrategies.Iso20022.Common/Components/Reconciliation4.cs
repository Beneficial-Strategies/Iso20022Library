// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation4.
/// </summary>
[IsoId("_cS2iUXqBEe6YlIMyoxWMJA")]
[DisplayName("Reconciliation4")]
public record Reconciliation4
{
    /// <summary>
    /// Checkpoint Reference.
    /// </summary>
    [DisplayName("Checkpoint Reference")]
    [IsoXmlTag("ChckptRef")]
    public IsoMax35Text? CheckpointReference { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }
}
