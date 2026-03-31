// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount4Choice
{
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_ICF6EbXQEeiTob_PrFFUxA")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public record SecuritiesQuantity : SecuritiesQuantityOrAmount4Choice_
    {
        /// <summary>
        /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
        /// </summary>
        [IsoId("_IVbs0bXQEeiTob_PrFFUxA")]
        [DisplayName("Conditional Quantity")]
        [IsoXmlTag("CondlQty")]
        public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; }

        /// <summary>
        /// Quantity of securities to which this instruction applies.
        /// </summary>
        [IsoId("_IVbs2bXQEeiTob_PrFFUxA")]
        [DisplayName("Instructed Quantity")]
        [IsoXmlTag("InstdQty")]
        public required Quantity20Choice_ InstructedQuantity { get; init; }

        /// <summary>
        /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
        /// </summary>
        [IsoId("_T38GsLXQEeiTob_PrFFUxA")]
        [DisplayName("Additional Round Up Quantity")]
        [IsoXmlTag("AddtlRndUpQty")]
        public FinancialInstrumentQuantity1Choice_? AdditionalRoundUpQuantity { get; init; }
    }
}
