// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message reference of relevance to the present message.
/// </summary>
[IsoId("_RB5f4tp-Ed-ak6NoX_4Aeg_1955131952")]
[DisplayName("Message Reference")]
public record MessageReference
{
    /// <summary>
    /// Business reference of the present message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
    /// </summary>
    [IsoId("_RB5f49p-Ed-ak6NoX_4Aeg_1955131953")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }
}
