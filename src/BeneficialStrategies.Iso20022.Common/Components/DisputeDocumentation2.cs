// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Documentation information relevant to the destination.
/// </summary>
[IsoId("_L5P44WvYEfCyxsm1jzUNug")]
[DisplayName("Dispute Documentation2")]
public record DisputeDocumentation2
{
    /// <summary>
    /// Format of the additional information. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_L7k0IWvYEfCyxsm1jzUNug")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat6Code? Format { get; init; }

    /// <summary>
    /// Defines the type of the value.
    /// </summary>
    [IsoId("_L7k0JWvYEfCyxsm1jzUNug")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_L7k0J2vYEfCyxsm1jzUNug")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required IsoMax20KText Value { get; init; }
}
