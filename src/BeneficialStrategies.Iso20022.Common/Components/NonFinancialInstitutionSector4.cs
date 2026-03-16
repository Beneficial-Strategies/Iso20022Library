// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information concerning non financial counterparties.
/// </summary>
[IsoId("_MU138QbWEeqrW7Meu5r3kQ")]
[DisplayName("Non Financial Institution Sector")]
public record NonFinancialInstitutionSector4
{
    /// <summary>
    /// Indicates that reporting party is a central counterparty.
    /// </summary>
    [IsoId("_MdCKqQbWEeqrW7Meu5r3kQ")]
    [DisplayName("Non Financial Institution")]
    [IsoXmlTag("NFI")]
    public required NoReasonCode NonFinancialInstitution { get; init; }

    /// <summary>
    /// Identifies the non-financial institution.
    /// </summary>
    [IsoId("_VWgswAbWEeqrW7Meu5r3kQ")]
    [DisplayName("Non Financial Institution Identifier")]
    [IsoXmlTag("NFIIdr")]
    public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; init; }
}
