// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to display, print or log.
/// </summary>
[IsoId("_Nf6MEYqHEeSRT5rEzcAHEw")]
[DisplayName("Action Message")]
public record ActionMessage4
{
    /// <summary>
    /// Information format.
    /// </summary>
    [IsoId("_Nsa-E4qHEeSRT5rEzcAHEw")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat2Code? Format { get; init; }

    /// <summary>
    /// Content of the message.
    /// </summary>
    [IsoId("_Nsa-FYqHEeSRT5rEzcAHEw")]
    [DisplayName("Message")]
    [IsoXmlTag("Msg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? Message { get; init; }

    /// <summary>
    /// Message content if this is a message reference or screen reference.
    /// </summary>
    [IsoId("_zAVggIqHEeSRT5rEzcAHEw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Device to be used.
    /// </summary>
    [IsoId("_cCmkAIqIEeSRT5rEzcAHEw")]
    [DisplayName("Device")]
    [IsoXmlTag("Dvc")]
    public ATMDevice1Code? Device { get; init; }

    /// <summary>
    /// Electronic signature of the message to display or print.
    /// </summary>
    [IsoId("_ki80cIqIEeSRT5rEzcAHEw")]
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? MessageContentSignature { get; init; }
}
