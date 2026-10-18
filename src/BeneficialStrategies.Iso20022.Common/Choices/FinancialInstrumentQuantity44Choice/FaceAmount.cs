// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity44Choice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_ptJrSTi7Eeydid5dcNPKvg")]
    [DisplayName("Face Amount")]
    public record FaceAmount : FinancialInstrumentQuantity44Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FaceAmt")]
        public required RestrictedFINImpliedCurrencyAndAmount Value { get; init; }
    }
}
