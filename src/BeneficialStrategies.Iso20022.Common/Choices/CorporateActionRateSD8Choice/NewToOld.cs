// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionRateSD8Choice
{
    /// <summary>Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited.</summary>
    [IsoId("_0XjYabskEfCWCehgFzyN4w")]
    [DisplayName("New To Old")]
    public record NewToOld : CorporateActionRateSD8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NewToOd")]
        public required RatioFormat24Choice_ Value { get; init; }
    }
}
