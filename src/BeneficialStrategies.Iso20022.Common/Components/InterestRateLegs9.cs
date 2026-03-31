// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to interest rate attributes.
/// </summary>
[IsoId("_5tHsQVfREeqqKf65rDYWYw")]
[DisplayName("Interest Rate Legs")]
public record InterestRateLegs9
{
    /// <summary>
    /// Details concerning the rate in the first leg of an interest rate contract.
    /// </summary>
    [IsoId("_6Hvyw1fREeqqKf65rDYWYw")]
    [DisplayName("First Leg")]
    [IsoXmlTag("FrstLeg")]
    public InterestRate23Choice_? FirstLeg { get; init; }

    /// <summary>
    /// Details concerning the rate in the second leg of an interest rate contract.
    /// </summary>
    [IsoId("_6HvyxVfREeqqKf65rDYWYw")]
    [DisplayName("Second Leg")]
    [IsoXmlTag("ScndLeg")]
    public InterestRate23Choice_? SecondLeg { get; init; }
}
