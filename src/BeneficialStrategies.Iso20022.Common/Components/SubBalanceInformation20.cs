// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_jNUrhSp6EeyR9JrVGfaMKw")]
[DisplayName("Sub Balance Information")]
public record SubBalanceInformation20
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_jkHa5Sp6EeyR9JrVGfaMKw")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType11Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_jkHa7Sp6EeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Balance21 Quantity { get; init; }

    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_jkHa9Sp6EeyR9JrVGfaMKw")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_jkHa_Sp6EeyR9JrVGfaMKw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown57> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_jkHbBSp6EeyR9JrVGfaMKw")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation20> AdditionalBalanceBreakdownDetails { get; init; } =
        [];
}
