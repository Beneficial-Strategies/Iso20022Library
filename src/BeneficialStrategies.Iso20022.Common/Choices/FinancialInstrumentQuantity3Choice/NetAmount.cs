// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity3Choice
{
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold.
    /// </summary>
    [IsoId("_VO3Pkdp-Ed-ak6NoX_4Aeg_1922478152")]
    [DisplayName("Net Amount")]
    public record NetAmount : FinancialInstrumentQuantity3Choice_
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
