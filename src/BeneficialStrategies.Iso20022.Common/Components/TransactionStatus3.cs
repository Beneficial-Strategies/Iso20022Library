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
[IsoId("_RKFyk9p-Ed-ak6NoX_4Aeg_-489445133")]
[DisplayName("Transaction Status")]
public record TransactionStatus3
{
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RKFylNp-Ed-ak6NoX_4Aeg_-460815143")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus2Code Status { get; init; }
}
