// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the merchant.
/// </summary>
[IsoId("_0MN8QTAZEeugIJ3Gvoevmg")]
[DisplayName("Merchant Configuration Parameters")]
public record MerchantConfigurationParameters6
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_0YL7sTAZEeugIJ3Gvoevmg")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the merchant for the MTM, if the POI manages several merchants.
    /// </summary>
    [IsoId("_0YL7szAZEeugIJ3Gvoevmg")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MerchantIdentification { get; init; }

    /// <summary>
    /// Version of the merchant parameters.
    /// </summary>
    [IsoId("_0YL7tTAZEeugIJ3Gvoevmg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_0YL7tzAZEeugIJ3Gvoevmg")]
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; }

    /// <summary>
    /// Local proxy configuration.
    /// </summary>
    [IsoId("_0YL7uTAZEeugIJ3Gvoevmg")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public NetworkParameters8? Proxy { get; init; }

    /// <summary>
    /// Full length of other parameters.
    /// </summary>
    [IsoId("_tMDFIzAZEeugIJ3Gvoevmg")]
    [DisplayName("Other Parameters Length")]
    [IsoXmlTag("OthrParamsLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OtherParametersLength { get; init; }

    /// <summary>
    /// Place of this  Block, beginning with 0, in the full other parameters.
    /// </summary>
    [IsoId("_tMDFJDAZEeugIJ3Gvoevmg")]
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetStart { get; init; }

    /// <summary>
    /// Following place of this Block in the full other parameters.
    /// </summary>
    [IsoId("_tMDFJTAZEeugIJ3Gvoevmg")]
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetEnd { get; init; }

    /// <summary>
    /// Other merchant parameters.
    /// </summary>
    [IsoId("_0YL7uzAZEeugIJ3Gvoevmg")]
    [DisplayName("Other Parameters")]
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? OtherParameters { get; init; }
}
