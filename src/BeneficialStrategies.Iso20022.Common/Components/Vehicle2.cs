// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information related to a vehicle.
/// </summary>
[IsoId("_nC2q8ZdOEeWhUvuI1bSHSA")]
[DisplayName("Vehicle")]
public record Vehicle2
{
    /// <summary>
    /// Type of information related to the vehicle.
    /// </summary>
    [IsoId("_4aiIcJdOEeWhUvuI1bSHSA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Entry mode of the information.
    /// </summary>
    [IsoId("_nN4PN5dOEeWhUvuI1bSHSA")]
    [DisplayName("Entry Mode")]
    [IsoXmlTag("NtryMd")]
    public CardDataReading5Code? EntryMode { get; init; }

    /// <summary>
    /// Information related to the vehicle.
    /// </summary>
    [IsoId("_nN4PSZdOEeWhUvuI1bSHSA")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Data { get; init; }
}
