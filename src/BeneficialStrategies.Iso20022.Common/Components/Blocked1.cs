// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about blocked accounts.
/// </summary>
[IsoId("_K0XSoBHCEeKVqeHljBM1MQ")]
[DisplayName("Blocked")]
public record Blocked1
{
    /// <summary>
    /// Specifies the order type for which the account is blocked.
    /// </summary>
    [IsoId("_kTNEgBHCEeKVqeHljBM1MQ")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType1Choice_> OrderType { get; init; } = [];

    // ID for the above is _kTNEgBHCEeKVqeHljBM1MQ

    /// <summary>
    /// Indicates whether the account is blocked.
    /// </summary>
    [IsoId("_wy--8BHCEeKVqeHljBM1MQ")]
    [DisplayName("Blocked")]
    [IsoXmlTag("Blckd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Blocked { get; init; }

    /// <summary>
    /// Specifies the reason the account is blocked.
    /// </summary>
    [IsoId("_4ixVIBHCEeKVqeHljBM1MQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public BlockedReason1Choice_? Reason { get; init; }
}
