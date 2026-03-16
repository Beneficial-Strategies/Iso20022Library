// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the destination.
/// </summary>
[IsoId("_CXl9EYv0EeumSPwlS1PkxQ")]
[DisplayName("Destination")]
public record Destination3
{
    /// <summary>
    /// Name and location of the destination.  May only contain the name if the location is specified elsewhere.
    /// </summary>
    [IsoId("_Cda4QYv0EeumSPwlS1PkxQ")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? NameAndLocation { get; init; }

    /// <summary>
    /// Specific address of the destination.
    /// </summary>
    [IsoId("_Cda4Q4v0EeumSPwlS1PkxQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }
}
