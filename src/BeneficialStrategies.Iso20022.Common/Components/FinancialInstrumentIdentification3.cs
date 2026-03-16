// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[IsoId("_yS2z4Zy1Eem54rMzia0iag")]
[DisplayName("Financial Instrument Identification")]
public record FinancialInstrumentIdentification3
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_ymDcs5y1Eem54rMzia0iag")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_ymDctZy1Eem54rMzia0iag")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_ymDct5y1Eem54rMzia0iag")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Type of security.
    /// </summary>
    [IsoId("_ymDcuZy1Eem54rMzia0iag")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Indicates whether the security is a restricted security.
    /// </summary>
    [IsoId("_ojOQYJy2Eem54rMzia0iag")]
    [DisplayName("Restricted Indicator")]
    [IsoXmlTag("RstrctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictedIndicator { get; init; }

    /// <summary>
    /// Alternative security offered in place of a restricted security.
    /// </summary>
    [IsoId("_4-IZEJy1Eem54rMzia0iag")]
    [DisplayName("Alternate Security")]
    [IsoXmlTag("AltrnScty")]
    public ValueList<FinancialInstrumentIdentification4> AlternateSecurity { get; init; } = [];
}
