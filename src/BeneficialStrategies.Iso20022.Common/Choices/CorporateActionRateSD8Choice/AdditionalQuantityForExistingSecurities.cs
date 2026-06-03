// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionRateSD8Choice
{
    /// <summary>Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited.</summary>
    [IsoId("_0XjYYbskEfCWCehgFzyN4w")]
    [DisplayName("Additional Quantity For Existing Securities")]
    public record AdditionalQuantityForExistingSecurities : CorporateActionRateSD8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AddtlQtyForExstgScties")]
        public required RatioFormat23Choice_ Value { get; init; }
    }
}
