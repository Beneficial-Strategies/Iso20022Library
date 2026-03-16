// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOrFaceAmountOrCodeChoice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, ie, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_Sokixtp-Ed-ak6NoX_4Aeg_1106804711")]
    [DisplayName("Face Amount")]
    public record FaceAmount : UnitOrFaceAmountOrCodeChoice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Currency")]
        [DisplayName("Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Amount")]
        [DisplayName("Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
