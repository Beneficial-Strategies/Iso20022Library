// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-balances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
[IsoId("_lMvTxSp8EeyR9JrVGfaMKw")]
[DisplayName("Additional Balance Information")]
public record AdditionalBalanceInformation22
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_lkba5Sp8EeyR9JrVGfaMKw")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType12Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_lkba7Sp8EeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity8Choice_ Quantity { get; init; }

    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_lkba9Sp8EeyR9JrVGfaMKw")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; }
}
