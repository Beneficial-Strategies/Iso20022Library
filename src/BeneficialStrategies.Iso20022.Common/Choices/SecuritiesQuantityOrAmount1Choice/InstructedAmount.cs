// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount1Choice
{
    /// <summary>
    /// Cash amount to be instructed.
    /// </summary>
    [IsoId("_Ln7UUIlYEeavwKddCbm3hg")]
    [DisplayName("Instructed Amount")]
    public record InstructedAmount : SecuritiesQuantityOrAmount1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_WOVvkNp-Ed-ak6NoX_4Aeg_-1267706960_Currency")]
        [DisplayName("Restricted FIN Active Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_WOVvkNp-Ed-ak6NoX_4Aeg_-1267706960_Amount")]
        [DisplayName("Restricted FIN Active Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
