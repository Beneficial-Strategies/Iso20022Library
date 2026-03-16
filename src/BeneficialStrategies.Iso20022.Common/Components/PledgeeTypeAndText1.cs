// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
/// </summary>
[IsoId("_bBLbIE9fEeSn2-3swbRbzg")]
[DisplayName("Pledgee Type And Text")]
public record PledgeeTypeAndText1
{
    /// <summary>
    /// Additional information about the entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_LkM6UE9gEeSn2-3swbRbzg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    [IsoId("_iSB9IE9gEeSn2-3swbRbzg")]
    [DisplayName("Pledgee Type")]
    [IsoXmlTag("PldgeeTp")]
    public required PledgeeType1Code PledgeeType { get; init; }
}
