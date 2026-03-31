// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services carries telephony billing data.
/// </summary>
[IsoId("_vShsAR1DEey8XKHwKquEQw")]
[DisplayName("Telecom Services")]
public record TelecomServices2
{
    /// <summary>
    /// Telecom Services Summary component is designed to carry summary level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_vZWswR1DEey8XKHwKquEQw")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public TelecomServicesSummary2? Summary { get; init; }

    /// <summary>
    /// Telecom Services Line Item component is designed to carry detail level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_vZWswx1DEey8XKHwKquEQw")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<TelecomServicesLineItem2> LineItem { get; init; } = [];
}
