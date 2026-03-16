// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the status of the transaction by means of a code.
/// </summary>
[IsoId("_RbFb-Np-Ed-ak6NoX_4Aeg_1598523783")]
[DisplayName("Transaction Status")]
public record TransactionStatus4
{
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RbOl4Np-Ed-ak6NoX_4Aeg_1598523785")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus3Code Status { get; init; }
}
