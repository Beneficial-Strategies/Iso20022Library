// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation4"/>
[IsoId("_PhVsEtp-Ed-ak6NoX_4Aeg_453123857")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation4
{
    /// <inheritdoc cref="IOriginalGroupInformation4.OriginalMessageIdentification"/>
    [IsoId("_PhVsE9p-Ed-ak6NoX_4Aeg_453123876")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation4.OriginalMessageNameIdentification"/>
    [IsoId("_PhVsFNp-Ed-ak6NoX_4Aeg_453123952")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation4.OriginalCreationDateTime"/>
    [IsoId("_PhVsFdp-Ed-ak6NoX_4Aeg_-1547891782")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation4.CancellationReasonInformation"/>
    [IsoId("_PhVsFtp-Ed-ak6NoX_4Aeg_-1239359353")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<CancellationReasonInformation1> CancellationReasonInformation { get; init; } =
        [];
}
