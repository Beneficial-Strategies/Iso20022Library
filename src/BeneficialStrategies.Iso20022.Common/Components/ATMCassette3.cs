// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Cassette3.
/// </summary>
[IsoId("_5Q4ogaDlEe-MRKYsaX6JDg")]
[DisplayName("ATM Cassette3")]
public record ATMCassette3
{
    /// <summary>
    /// Cassette Status.
    /// </summary>
    [DisplayName("Cassette Status")]
    [IsoXmlTag("CssttSts")]
    public ATMCassetteStatus1Code? CassetteStatus { get; init; }

    /// <summary>
    /// Logical Identification.
    /// </summary>
    [DisplayName("Logical Identification")]
    [IsoXmlTag("LogclId")]
    public required IsoMax35Text LogicalIdentification { get; init; }

    /// <summary>
    /// Media Counters.
    /// </summary>
    [DisplayName("Media Counters")]
    [IsoXmlTag("MdiaCntrs")]
    public ValueList<ATMCassetteCounters6> MediaCounters { get; init; } = [];

    /// <summary>
    /// Media Type.
    /// </summary>
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public ATMMediaType4Code? MediaType { get; init; }

    /// <summary>
    /// Physical Identification.
    /// </summary>
    [DisplayName("Physical Identification")]
    [IsoXmlTag("PhysId")]
    public IsoMax35Text? PhysicalIdentification { get; init; }

    /// <summary>
    /// Serial Number.
    /// </summary>
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Sub Type.
    /// </summary>
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public ValueList<ATMNoteType1Code> SubType { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCassetteType1Code Type { get; init; }
}
