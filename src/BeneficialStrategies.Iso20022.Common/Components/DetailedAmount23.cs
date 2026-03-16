// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_5bTz0ZMgEeuleeHpFMMhmQ")]
[DisplayName("Detailed Amount")]
public record DetailedAmount23
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_5iOUIZMgEeuleeHpFMMhmQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DetailAmount2Code Type { get; init; }

    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_5iOUI5MgEeuleeHpFMMhmQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Amount of one occurrence of the breakdown amount.
    /// </summary>
    [IsoId("_5iOUJZMgEeuleeHpFMMhmQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount16 Amount { get; init; }

    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("_5iOUJ5MgEeuleeHpFMMhmQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Description { get; init; }
}
