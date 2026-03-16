// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity2Choice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_Sn-F1dp-Ed-ak6NoX_4Aeg_-85763273")]
    [DisplayName("Face Amount")]
    public record FaceAmount : FinancialInstrumentQuantity2Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YXbjBNp-Ed-ak6NoX_4Aeg_-1934687468_Currency")]
        [DisplayName("Implied Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YXbjBNp-Ed-ak6NoX_4Aeg_-1934687468_Amount")]
        [DisplayName("Implied Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
