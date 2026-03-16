// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the references of the underlying trade leg(s) and/or the reference to the related NetPosition report message.
/// </summary>
[IsoId("_Ql4SRdp-Ed-ak6NoX_4Aeg_1999754651")]
[DisplayName("Reference")]
public record Reference19
{
    /// <summary>
    /// Reference allocated by the central counterparty - central counterpatry trade leg reference identification that uniquely identifies the trade.
    /// </summary>
    [IsoId("_Ql4SRtp-Ed-ak6NoX_4Aeg_1904546885")]
    [DisplayName("Trade Leg Notification Identification")]
    [IsoXmlTag("TradLegNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TradeLegNotificationIdentification { get; init; }

    /// <summary>
    /// After netting, reference that is common to a net transaction to settle and all its underlying trades.
    /// </summary>
    [IsoId("_Ql4SR9p-Ed-ak6NoX_4Aeg_-321657762")]
    [DisplayName("Net Position Identification")]
    [IsoXmlTag("NetPosId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NetPositionIdentification { get; init; }
}
