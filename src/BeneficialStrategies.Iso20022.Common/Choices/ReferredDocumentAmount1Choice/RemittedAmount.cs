// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice
{
    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_QGJCRdp-Ed-ak6NoX_4Aeg_-888106457")]
    [DisplayName("Remitted Amount")]
    public record RemittedAmount : ReferredDocumentAmount1Choice_
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
