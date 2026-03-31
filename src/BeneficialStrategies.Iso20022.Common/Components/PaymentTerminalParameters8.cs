// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Manufacturer configuration parameters of the point of interaction (POI).
/// </summary>
[IsoId("_clS40TAaEeugIJ3Gvoevmg")]
[DisplayName("Payment Terminal Parameters")]
public record PaymentTerminalParameters8
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_cwnYATAaEeugIJ3Gvoevmg")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the vendor for the MTM, if the POI manages various subsets of terminal parameters.
    /// </summary>
    [IsoId("_cwnYAzAaEeugIJ3Gvoevmg")]
    [DisplayName("Vendor Identification")]
    [IsoXmlTag("VndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? VendorIdentification { get; init; }

    /// <summary>
    /// Version of the terminal parameters.
    /// </summary>
    [IsoId("_cwnYBTAaEeugIJ3Gvoevmg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_cwnYBzAaEeugIJ3Gvoevmg")]
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; }

    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_cwnYCTAaEeugIJ3Gvoevmg")]
    [DisplayName("Clock Synchronisation")]
    [IsoXmlTag("ClckSynctn")]
    public ClockSynchronisation3? ClockSynchronisation { get; init; }

    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_cwnYCzAaEeugIJ3Gvoevmg")]
    [DisplayName("Time Zone Line")]
    [IsoXmlTag("TmZoneLine")]
    public SimpleValueList<IsoMax70Text> TimeZoneLine { get; init; } = [];

    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    [IsoId("_cwnYDTAaEeugIJ3Gvoevmg")]
    [DisplayName("Local Date Time")]
    [IsoXmlTag("LclDtTm")]
    public ValueList<LocalDateTime1> LocalDateTime { get; init; } = [];

    /// <summary>
    /// Full length of other parameters.
    /// </summary>
    [IsoId("_vJGyQzAaEeugIJ3Gvoevmg")]
    [DisplayName("Other Parameters Length")]
    [IsoXmlTag("OthrParamsLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OtherParametersLength { get; init; }

    /// <summary>
    /// Place of this  Block, beginning with 0, in the full other parameters.
    /// </summary>
    [IsoId("_vJGyRDAaEeugIJ3Gvoevmg")]
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetStart { get; init; }

    /// <summary>
    /// Following place of this Block in the full other parameters.
    /// </summary>
    [IsoId("_vJGyRTAaEeugIJ3Gvoevmg")]
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetEnd { get; init; }

    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_cwnYDzAaEeugIJ3Gvoevmg")]
    [DisplayName("Other Parameters")]
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? OtherParameters { get; init; }
}
