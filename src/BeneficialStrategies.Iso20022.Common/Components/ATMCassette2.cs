// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the cassette of an ATM.
/// </summary>
[IsoId("_UgWjka4MEeWZgJQOa6iKCQ")]
[DisplayName("ATM Cassette")]
public record ATMCassette2
{
    /// <summary>
    /// Physical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_UrYH0a4MEeWZgJQOa6iKCQ")]
    [DisplayName("Physical Identification")]
    [IsoXmlTag("PhysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PhysicalIdentification { get; init; }

    /// <summary>
    /// Logical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_UrYH064MEeWZgJQOa6iKCQ")]
    [DisplayName("Logical Identification")]
    [IsoXmlTag("LogclId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text LogicalIdentification { get; init; }

    /// <summary>
    /// Serial number or unique identification of the cassette hardware.
    /// </summary>
    [IsoId("_dqlegK4MEeWZgJQOa6iKCQ")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Type of cassette.
    /// </summary>
    [IsoId("_UrYH1a4MEeWZgJQOa6iKCQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCassetteType1Code Type { get; init; }

    /// <summary>
    /// Type of items the cash-in takes.
    /// </summary>
    [IsoId("_UrYH164MEeWZgJQOa6iKCQ")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public SimpleValueList<ATMNoteType1Code> SubType { get; init; } = [];

    /// <summary>
    /// Type of media inside the cassette.
    /// </summary>
    [IsoId("_UrYH2a4MEeWZgJQOa6iKCQ")]
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public ATMMediaType1Code? MediaType { get; init; }

    /// <summary>
    /// Counter per unit value or globally.
    /// </summary>
    [IsoId("_UrYH264MEeWZgJQOa6iKCQ")]
    [DisplayName("Media Counters")]
    [IsoXmlTag("MdiaCntrs")]
    public ValueList<ATMCassetteCounters3> MediaCounters { get; init; } = [];
}
