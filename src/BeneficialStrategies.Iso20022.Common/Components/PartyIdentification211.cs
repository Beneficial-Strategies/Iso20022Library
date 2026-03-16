// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_k0uOwECFEeeXpbqDpLawug")]
[DisplayName("Party Identification")]
public record PartyIdentification211
{
    /// <summary>
    /// Financial institution-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_zQJWgkCFEeeXpbqDpLawug")]
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution4? FinancialInstitution { get; init; }

    /// <summary>
    /// Customer-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_zQJWg0CFEeeXpbqDpLawug")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer3? Customer { get; init; }
}
