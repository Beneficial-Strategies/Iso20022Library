// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a master agreement.
/// </summary>
[IsoId("_hXlS0ZQuEeyb24yfD-3rmg")]
[DisplayName("Master Agreement")]
public record MasterAgreement8
{
    /// <summary>
    /// Reference to any master agreement, if existent (such as ISDA Master Agreement; Master Power Purchase and Sale Agreement; International ForEx Master Agreement; European Master Agreement or any local Master Agreements).
    /// </summary>
    [IsoId("_hZsLoZQuEeyb24yfD-3rmg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AgreementType2Choice_? Type { get; init; }

    /// <summary>
    /// Reference to the year of the master agreement version used for the reported trade, if applicable (such as 1992, 2002, etc).
    /// </summary>
    [IsoId("_hZsLo5QuEeyb24yfD-3rmg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? Version { get; init; }

    /// <summary>
    /// Additional information specifying the other type of the master agreement.
    /// </summary>
    [IsoId("_hZsLpZQuEeyb24yfD-3rmg")]
    [DisplayName("Other Master Agreement Details")]
    [IsoXmlTag("OthrMstrAgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? OtherMasterAgreementDetails { get; init; }
}
