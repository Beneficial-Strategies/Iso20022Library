// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of detailed aggregated position set report between a pair of counterparties.
/// </summary>
[IsoId("_0nw0hcKwEeuM4pgP8Vixbg")]
[DisplayName("Named Position")]
public record NamedPosition3
{
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    [IsoId("_52PEgMKwEeuM4pgP8Vixbg")]
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReferenceDate { get; init; }

    /// <summary>
    /// Report containing aggregation of loan and collateral exposures between counterparties by Securities Financing Transaction type, for a limited number of fields.
    /// </summary>
    [IsoId("_0pQCQ8KwEeuM4pgP8Vixbg")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public ValueList<PositionSet16> GeneralInformation { get; init; } = [];

    /// <summary>
    /// Aggregation of data for all transactions pertaining to the loan side, by Securities Financing Transaction type.
    /// </summary>
    [IsoId("_0pQCRcKwEeuM4pgP8Vixbg")]
    [DisplayName("Loan")]
    [IsoXmlTag("Ln")]
    public ValueList<PositionSet17> Loan { get; init; } = [];

    /// <summary>
    /// Aggregation of data for all submissions pertaining to the collateral side, by Securities Financing Transaction type.
    /// </summary>
    [IsoId("_0pQCR8KwEeuM4pgP8Vixbg")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public ValueList<PositionSet18> Collateral { get; init; } = [];

    /// <summary>
    /// Aggregation of data related to margin reported for cleared Securities Financing Transactions at the level of each pair of entities and portfolio code.
    /// </summary>
    [IsoId("_0pQCScKwEeuM4pgP8Vixbg")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public ValueList<PositionSet20> Margin { get; init; } = [];

    /// <summary>
    /// Aggregation of data on collateral reuse transactions, at entity level.
    /// </summary>
    [IsoId("_0pQCS8KwEeuM4pgP8Vixbg")]
    [DisplayName("Reuse")]
    [IsoXmlTag("Reuse")]
    public ValueList<PositionSet19> Reuse { get; init; } = [];
}
