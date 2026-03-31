// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity43Choice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_ptGAjTi7Eeydid5dcNPKvg")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public record FaceAmount : FinancialInstrumentQuantity43Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429_Currency")]
        [DisplayName("Restricted FIN Implied Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429_Amount")]
        [DisplayName("Restricted FIN Implied Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
