// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reconciliation period between an acquirer and an issuer or their respective agents.
/// </summary>
[IsoId("_bjH8Ua25EfCKbLfqFyM0kg")]
[DisplayName("Reconciliation5")]
public record Reconciliation5
{
    /// <summary>
    /// Identification of the reconciliation.
    /// </summary>
    [IsoId("_bmMeca25EfCKbLfqFyM0kg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax50Text? Identification { get; init; }

    /// <summary>
    /// Date of the reconciliation.
    /// </summary>
    [IsoId("_bmMec625EfCKbLfqFyM0kg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// A value used to allow a period within a reconciliation date.
    /// </summary>
    [IsoId("_bmMee625EfCKbLfqFyM0kg")]
    [DisplayName("Checkpoint Reference")]
    [IsoXmlTag("ChckptRef")]
    public IsoMax35Text? CheckpointReference { get; init; }
}
