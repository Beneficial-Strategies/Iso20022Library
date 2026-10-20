// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity46Choice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_DcYV6zT5Ee2j2eQlcOSMKg")]
    [DisplayName("Face Amount")]
    public partial record FaceAmount : FinancialInstrumentQuantity46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FaceAmt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
