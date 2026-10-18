// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalMessageInformation1"/>
[IsoId("_PgJZVdp-Ed-ak6NoX_4Aeg_1129957204")]
[DisplayName("Original Message Information")]
public partial record OriginalMessageInformation1
{
    /// <inheritdoc cref="IOriginalMessageInformation1.MessageIdentification"/>
    [IsoId("_PgJZVtp-Ed-ak6NoX_4Aeg_1215844112")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalMessageInformation1.MessageNameIdentification"/>
    [IsoId("_PgJZV9p-Ed-ak6NoX_4Aeg_1215844113")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalMessageInformation1.CreationDateTime"/>
    [IsoId("_PgTKQNp-Ed-ak6NoX_4Aeg_1215844134")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }
}
