// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_9Fk_wf_oEeCiHMrKuf9tBw")]
[DisplayName("Sub Balance Information")]
public record SubBalanceInformation9
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_9Fk_z__oEeCiHMrKuf9tBw")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType5Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_9Fk_2f_oEeCiHMrKuf9tBw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity3Choice_ Quantity { get; init; }

    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_9Fk_4__oEeCiHMrKuf9tBw")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_9Fk_7f_oEeCiHMrKuf9tBw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown13> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_9Fk_9__oEeCiHMrKuf9tBw")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation9> AdditionalBalanceBreakdownDetails { get; init; } =
        [];
}
