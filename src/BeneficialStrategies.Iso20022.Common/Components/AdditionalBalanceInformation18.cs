// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subbalances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
[IsoId("_ttFgidLHEeiN28wlpBQScw")]
[DisplayName("Additional Balance Information")]
public record AdditionalBalanceInformation18
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_t-DUldLHEeiN28wlpBQScw")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType12Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_t-DUndLHEeiN28wlpBQScw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Balance9 Quantity { get; init; }

    /// <summary>
    /// Provides additional sub-balance information.
    /// </summary>
    [IsoId("_t-DUpdLHEeiN28wlpBQScw")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_t-DUrdLHEeiN28wlpBQScw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown54> QuantityBreakdown { get; init; } = [];
}
