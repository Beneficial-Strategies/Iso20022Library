// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed.
/// </summary>
[IsoId("_2bVsUcVgEeuips4fuphvoQ")]
[DisplayName("Action")]
public record Action13
{
    /// <summary>
    /// Destination of the action.
    /// </summary>
    [IsoId("_2gZLccVgEeuips4fuphvoQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyType20Code? Destination { get; init; }

    /// <summary>
    /// Action type to be performed.
    /// </summary>
    [IsoId("_2gZLc8VgEeuips4fuphvoQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public ActionType11Code? ActionType { get; init; }

    /// <summary>
    /// Other action type to be performed.
    /// </summary>
    [IsoId("_2gZLdcVgEeuips4fuphvoQ")]
    [DisplayName("Other Action Type")]
    [IsoXmlTag("OthrActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherActionType { get; init; }

    /// <summary>
    /// Contact information.
    /// </summary>
    [IsoId("_LFdK8MVhEeuips4fuphvoQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; }

    /// <summary>
    /// Additional action information.
    /// </summary>
    [IsoId("_RpPBAMVhEeuips4fuphvoQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
