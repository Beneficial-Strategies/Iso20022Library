// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the related items or attachments (such as message types and number of messages types) within the file.
/// </summary>
[IsoId("_zswRIcF1EfC5bNIScwOWFA")]
[DisplayName("Manifest Data4")]
public record ManifestData4
{
    /// <summary>
    /// Specifies the type of items contained in the document set.
    /// </summary>
    [IsoId("_zvgqMcF1EfC5bNIScwOWFA")]
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    public SimpleValueList<IsoMax35Text> MessageDefinitionIdentifier { get; init; } = [];

    /// <summary>
    /// Identification of the format of the Business Message.
    /// </summary>
    [IsoId("_zvgqM8F1EfC5bNIScwOWFA")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public IsoMax35Text? Format { get; init; }

    /// <summary>
    /// Number of instances (messages) for each declared type.
    /// </summary>
    [IsoId("_zvgqNcF1EfC5bNIScwOWFA")]
    [DisplayName("Number Of Business Messages")]
    [IsoXmlTag("NbOfBizMsgs")]
    public IsoNumber? NumberOfBusinessMessages { get; init; }

    /// <summary>
    /// Specifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_zvhRQcF1EfC5bNIScwOWFA")]
    [DisplayName("Market Practice")]
    [IsoXmlTag("MktPrctc")]
    public ImplementationSpecification1? MarketPractice { get; init; }
}
