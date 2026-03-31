// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet data pertaining to the payment transaction.
/// </summary>
[IsoId("_FEPHAR1TEey8XKHwKquEQw")]
[DisplayName("Fleet Data")]
public record FleetData5
{
    /// <summary>
    /// It is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions.
    /// </summary>
    [IsoId("_FKop8R1TEey8XKHwKquEQw")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<FleetLineItem3> LineItem { get; init; } = [];
}
