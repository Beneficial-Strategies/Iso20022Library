// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial institution.
/// </summary>
[IsoId("_56x2kUmwEeaw890XtoVB-Q")]
[DisplayName("Financial Institution Identification")]
public record FinancialInstitutionIdentification10
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("__N1roEmwEeaw890XtoVB-Q")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required FinancialInstitutionIdentification8Choice_ Party { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_D6-JIUmxEeaw890XtoVB-Q")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
