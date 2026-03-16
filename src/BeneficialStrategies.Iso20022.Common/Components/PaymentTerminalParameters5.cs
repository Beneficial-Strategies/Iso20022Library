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
[IsoId("_wkqvcdqbEeearpaEPXv9UA")]
[DisplayName("Payment Terminal Parameters")]
public record PaymentTerminalParameters5
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_wtSf8dqbEeearpaEPXv9UA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the vendor for the MTM, if the POI manages various subsets of terminal parameters.
    /// </summary>
    [IsoId("_wtSf89qbEeearpaEPXv9UA")]
    [DisplayName("Vendor Identification")]
    [IsoXmlTag("VndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? VendorIdentification { get; init; }

    /// <summary>
    /// Version of the terminal parameters.
    /// </summary>
    [IsoId("_wtSf9dqbEeearpaEPXv9UA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_wtSf99qbEeearpaEPXv9UA")]
    [DisplayName("Clock Synchronisation")]
    [IsoXmlTag("ClckSynctn")]
    public ClockSynchronisation2? ClockSynchronisation { get; init; }

    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_wtSf-dqbEeearpaEPXv9UA")]
    [DisplayName("Time Zone Line")]
    [IsoXmlTag("TmZoneLine")]
    public SimpleValueList<IsoMax70Text> TimeZoneLine { get; init; } = [];

    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    [IsoId("_wtSf-9qbEeearpaEPXv9UA")]
    [DisplayName("Local Date Time")]
    [IsoXmlTag("LclDtTm")]
    public ValueList<LocalDateTime1> LocalDateTime { get; init; } = [];

    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_wtSf_dqbEeearpaEPXv9UA")]
    [DisplayName("Other Parameters")]
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? OtherParameters { get; init; }
}
