// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Payment Scenario1Choice.
    /// </summary>
    [KnownType(typeof(PaymentScenario1Choice.Code))]
    [KnownType(typeof(PaymentScenario1Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentScenario1Choice.Code), nameof(PaymentScenario1Choice.Code))]
    [JsonDerivedType(
        typeof(PaymentScenario1Choice.Proprietary),
        nameof(PaymentScenario1Choice.Proprietary)
    )]
    [IsoId("_J3dO8Gw9Ee-t2JGPeXy0Sw")]
    [DisplayName("Payment Scenario1Choice")]
    public abstract record PaymentScenario1Choice_ { }
}
