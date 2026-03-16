// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateDerivative2Choice
{
    /// <summary>
    /// Underlying interest rate type is a swap, swaption, a future on a swap or a forward on a swap with regard to the underlying swap.
    /// </summary>
    [IsoId("_xbbEcWlIEeaLAKoEUNsD9g")]
    [DisplayName("Swap Related")]
    public record SwapRelated : InterestRateDerivative2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.
        /// </summary>
        [IsoXmlTag("SwpRltd")]
        public required SwapType1Code Value { get; init; }
    }
}
