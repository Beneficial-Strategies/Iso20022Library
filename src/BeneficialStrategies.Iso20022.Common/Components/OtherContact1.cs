// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOtherContact1"/>
[IsoId("_6SokSZqlEeGSON8vddiWzQ_1969673172")]
[DisplayName("Other Contact")]
public partial record OtherContact1
{
    /// <inheritdoc cref="IOtherContact1.ChannelType"/>
    [IsoId("_6SokSpqlEeGSON8vddiWzQ_444512870")]
    [DisplayName("Channel Type")]
    [IsoXmlTag("ChanlTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4Text ChannelType { get; init; }

    /// <inheritdoc cref="IOtherContact1.Identification"/>
    [IsoId("_6SokS5qlEeGSON8vddiWzQ_938910947")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128, MinimumLength = 1)]
    public IsoMax128Text? Identification { get; init; }
}
