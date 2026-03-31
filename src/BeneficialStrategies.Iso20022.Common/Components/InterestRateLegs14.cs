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
[IsoId("_O8SFoSJLEe2zWP9pqvmqdw")]
[DisplayName("Interest Rate Legs")]
public record InterestRateLegs14
{
    /// <summary>
    /// Details concerning the rate in the first leg of an interest rate contract.
    /// </summary>
    [IsoId("_O9BsgyJLEe2zWP9pqvmqdw")]
    [DisplayName("First Leg")]
    [IsoXmlTag("FrstLeg")]
    public InterestRate33Choice_? FirstLeg { get; init; }

    /// <summary>
    /// Details concerning the rate in the second leg of an interest rate contract.
    /// </summary>
    [IsoId("_O9BshSJLEe2zWP9pqvmqdw")]
    [DisplayName("Second Leg")]
    [IsoXmlTag("ScndLeg")]
    public InterestRate33Choice_? SecondLeg { get; init; }
}
