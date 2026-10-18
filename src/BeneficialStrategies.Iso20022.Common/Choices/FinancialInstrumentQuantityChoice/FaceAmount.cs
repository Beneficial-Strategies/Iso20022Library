// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantityChoice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, ie, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_Sn-F2tp-Ed-ak6NoX_4Aeg_1583790387")]
    [DisplayName("Face Amount")]
    public record FaceAmount : FinancialInstrumentQuantityChoice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FaceAmt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
