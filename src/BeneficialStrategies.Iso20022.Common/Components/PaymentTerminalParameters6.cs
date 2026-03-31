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
[IsoId("_C7ZDYdX4Eeia9rtBTv_9KA")]
[DisplayName("Payment Terminal Parameters")]
public record PaymentTerminalParameters6
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_DFD8wdX4Eeia9rtBTv_9KA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the vendor for the MTM, if the POI manages various subsets of terminal parameters.
    /// </summary>
    [IsoId("_DFD8w9X4Eeia9rtBTv_9KA")]
    [DisplayName("Vendor Identification")]
    [IsoXmlTag("VndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? VendorIdentification { get; init; }

    /// <summary>
    /// Version of the terminal parameters.
    /// </summary>
    [IsoId("_DFD8xdX4Eeia9rtBTv_9KA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_AEfHsdX4Eeia9rtBTv_9KA")]
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; }

    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_DFD8x9X4Eeia9rtBTv_9KA")]
    [DisplayName("Clock Synchronisation")]
    [IsoXmlTag("ClckSynctn")]
    public ClockSynchronisation2? ClockSynchronisation { get; init; }

    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_DFD8ydX4Eeia9rtBTv_9KA")]
    [DisplayName("Time Zone Line")]
    [IsoXmlTag("TmZoneLine")]
    public SimpleValueList<IsoMax70Text> TimeZoneLine { get; init; } = [];

    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    [IsoId("_DFD8y9X4Eeia9rtBTv_9KA")]
    [DisplayName("Local Date Time")]
    [IsoXmlTag("LclDtTm")]
    public ValueList<LocalDateTime1> LocalDateTime { get; init; } = [];

    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_DFD8zdX4Eeia9rtBTv_9KA")]
    [DisplayName("Other Parameters")]
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? OtherParameters { get; init; }
}
