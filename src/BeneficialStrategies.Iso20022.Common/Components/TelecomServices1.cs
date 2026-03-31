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
[IsoId("_2uCds_fNEei89sMSHxl1ew")]
[DisplayName("Telecom Services")]
public record TelecomServices1
{
    /// <summary>
    /// Telecom Services Summary component is designed to carry summary level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_2uCdtPfNEei89sMSHxl1ew")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public TelecomServicesSummary1? Summary { get; init; }

    /// <summary>
    /// Telecom Services Line Item component is designed to carry detail level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_2uCdtffNEei89sMSHxl1ew")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<TelecomServicesLineItem1> LineItem { get; init; } = [];
}
