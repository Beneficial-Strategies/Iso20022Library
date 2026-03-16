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
[IsoId("_GOMJAQ1IEeqV4s5SpzR1dQ")]
[DisplayName("Interest Rate Legs")]
public record InterestRateLegs7
{
    /// <summary>
    /// Details concerning the rate in the first leg of an interest rate contract.
    /// </summary>
    [IsoId("_GO8-AQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("First Leg")]
    [IsoXmlTag("FrstLeg")]
    public InterestRate21Choice_? FirstLeg { get; init; }

    /// <summary>
    /// Details concerning the rate in the second leg of an interest rate contract.
    /// </summary>
    [IsoId("_GO8-Aw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Second Leg")]
    [IsoXmlTag("ScndLeg")]
    public InterestRate21Choice_? SecondLeg { get; init; }
}
