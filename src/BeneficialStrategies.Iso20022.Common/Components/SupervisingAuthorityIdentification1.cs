// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of the relevant supervising authority.
/// </summary>
[IsoId("_YwcnkImiEeeS2PYASHZxtw")]
[DisplayName("Supervising Authority Identification")]
public record SupervisingAuthorityIdentification1
{
    /// <summary>
    /// Unique identification of the institution.
    /// </summary>
    [IsoId("_pZCxgImiEeeS2PYASHZxtw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public SupervisingAuthorityIdentification1Choice_? Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for an institution.
    /// </summary>
    [IsoId("_r3meoImiEeeS2PYASHZxtw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
