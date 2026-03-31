// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment related to the reconciliation of the transaction.
/// </summary>
[IsoId("_Mm3j8VA5EeedyPuM0kK2EQ")]
[DisplayName("Environment")]
public record Environment4
{
    /// <summary>
    /// Originator of the message.
    /// </summary>
    [IsoId("_Mx4hIVA5EeedyPuM0kK2EQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public Originator1? Originator { get; init; }

    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_Mx4hJ1A5EeedyPuM0kK2EQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public required Destination1 Destination { get; init; }
}
