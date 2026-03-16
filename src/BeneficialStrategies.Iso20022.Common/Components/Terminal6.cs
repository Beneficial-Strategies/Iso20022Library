// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction
/// </summary>
[IsoId("_F0hq0RyrEey6gI8SKlv7rg")]
[DisplayName("Terminal")]
public record Terminal6
{
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_F6TisRyrEey6gI8SKlv7rg")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    public required TerminalIdentification3 TerminalIdentification { get; init; }
}
