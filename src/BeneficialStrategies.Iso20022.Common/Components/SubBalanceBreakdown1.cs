// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single financial instrument within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_u5lkhYjkEeONZKAAW4pOaQ")]
[DisplayName("Sub Balance Breakdown")]
public record SubBalanceBreakdown1
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_u5lkj4jkEeONZKAAW4pOaQ")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType9Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of financial instrument in the sub-balance.
    /// </summary>
    [IsoId("_u5mLkIjkEeONZKAAW4pOaQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity5Choice_ Quantity { get; init; }
}
