// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation33"/>
[IsoId("cbf73edd-b654-4c5f-88c4-856c0c41d474")]
[DisplayName("Original Group Information33")]
public partial record OriginalGroupInformation33
{
    /// <inheritdoc cref="IOriginalGroupInformation33.OriginalMessageIdentification"/>
    [IsoId("8222206f-49ba-4180-aa0c-a8e82f8b6dd8")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation33.OriginalMessageNameIdentification"/>
    [IsoId("738f6e99-c66f-4c87-b2e4-469a21ebca6b")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation33.OriginalCreationDateTime"/>
    [IsoId("79f0fece-3e2c-4843-ace6-0239f629aaed")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }
}
