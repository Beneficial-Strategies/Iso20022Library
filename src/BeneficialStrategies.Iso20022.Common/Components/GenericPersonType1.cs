// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a generic type of identification requested for a person.
/// </summary>
[IsoId("_lvDzgnFwEemaN4ndAVY1ZQ")]
[DisplayName("Generic Person Type")]
public record GenericPersonType1
{
    /// <summary>
    /// Specifies whether the private type for the customer identification is requested or not.
    /// </summary>
    [IsoId("_lvDzhHFwEemaN4ndAVY1ZQ")]
    [DisplayName("Requested")]
    [IsoXmlTag("Reqd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator Requested { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_lvDzhnFwEemaN4ndAVY1ZQ")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public required PersonIdentificationSchemeName1Choice_ SchemeName { get; init; }
}
