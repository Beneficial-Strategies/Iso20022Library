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
[IsoId("_NOLh0U9YEeePXdaAO32Uew")]
[DisplayName("Terminal")]
public record Terminal2
{
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_NZVo8U9YEeePXdaAO32Uew")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    public required TerminalIdentification1 TerminalIdentification { get; init; }
}
