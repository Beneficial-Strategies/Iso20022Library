// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates whether the collateral is proprietarily owned or client owned.
/// </summary>
[IsoId("_wCIUQYFvEeWtPe6Crjmeug")]
[DisplayName("Collateral Ownership")]
public record CollateralOwnership2
{
    /// <summary>
    /// Indicates that the collateral is owned by the clearing member or not.
    /// </summary>
    [IsoId("_wXjxsYFvEeWtPe6Crjmeug")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Proprietary { get; init; }

    /// <summary>
    /// Indicates that the client owns the collateral.
    /// </summary>
    [IsoId("_wXjxs4FvEeWtPe6Crjmeug")]
    [DisplayName("Client Name")]
    [IsoXmlTag("ClntNm")]
    public PartyIdentification100Choice_? ClientName { get; init; }
}
