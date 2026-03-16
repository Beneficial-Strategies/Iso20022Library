// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dispute Documentation1.
/// </summary>
[IsoId("_SZJaMZg5Ee6OBt2eQPMPsQ")]
[DisplayName("Dispute Documentation1")]
public record DisputeDocumentation1
{
    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; }

    /// <summary>
    /// Other Format.
    /// </summary>
    [DisplayName("Other Format")]
    [IsoXmlTag("OthrFrmt")]
    public IsoMax35Text? OtherFormat { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required IsoMax20KText Value { get; init; }
}
