// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
/// </summary>
[IsoId("_vzEGEHYDEee_qcLXasnA4g")]
[DisplayName("Margin Account")]
public record MarginAccount1
{
    /// <summary>
    /// Unique identifier of the margin account.
    /// </summary>
    [IsoId("_1kQBkHYDEee_qcLXasnA4g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification118Choice_ Identification { get; init; }

    /// <summary>
    /// Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy.
    /// </summary>
    [IsoId("_5-_HgHYDEee_qcLXasnA4g")]
    [DisplayName("Position Account")]
    [IsoXmlTag("PosAcct")]
    public ValueList<PositionAccount1> PositionAccount { get; init; } = [];
    // ID for the above is _5-_HgHYDEee_qcLXasnA4g
}
