// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM terminal equipment.
/// </summary>
[IsoId("_eqOMIIn8EeShMpas3885ww")]
[DisplayName("ATM Equipment")]
public record ATMEquipment1
{
    /// <summary>
    /// ATM Manufacturer.
    /// </summary>
    [IsoId("_mJCHEIn8EeShMpas3885ww")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Manufacturer { get; init; }

    /// <summary>
    /// Model of ATM.
    /// </summary>
    [IsoId("_pkwnEIn8EeShMpas3885ww")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Model { get; init; }

    /// <summary>
    /// Serial number of the ATM.
    /// </summary>
    [IsoId("_sqRmgIn8EeShMpas3885ww")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Provider of the ATM application software.
    /// </summary>
    [IsoId("_vW_EYIn8EeShMpas3885ww")]
    [DisplayName("Application Provider")]
    [IsoXmlTag("ApplPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationProvider { get; init; }

    /// <summary>
    /// Name of the software product.
    /// </summary>
    [IsoId("_yIPrEIn8EeShMpas3885ww")]
    [DisplayName("Application Name")]
    [IsoXmlTag("ApplNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationName { get; init; }

    /// <summary>
    /// Current version of the software that might include the release number.
    /// </summary>
    [IsoId("_1TiiYIn8EeShMpas3885ww")]
    [DisplayName("Application Version")]
    [IsoXmlTag("ApplVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationVersion { get; init; }

    /// <summary>
    /// Unique assessment number for the component.
    /// </summary>
    [IsoId("_4CQycIn8EeShMpas3885ww")]
    [DisplayName("Approval Number")]
    [IsoXmlTag("ApprvlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApprovalNumber { get; init; }

    /// <summary>
    /// Configuration parameter version.
    /// </summary>
    [IsoId("_fAK8EIn-EeShMpas3885ww")]
    [DisplayName("Configuration Parameter")]
    [IsoXmlTag("CfgtnParam")]
    public ValueList<ATMConfigurationParameter1> ConfigurationParameter { get; init; } = [];
}
