// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount5Choice
{
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_qY_3q_fREeiNZp_PtLohLw")]
    [DisplayName("Securities Quantity")]
    public record SecuritiesQuantity : SecuritiesQuantityOrAmount5Choice_
    {
        /// <summary>
        /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
        /// </summary>
        [IsoId("_qY_3s_fREeiNZp_PtLohLw")]
        [DisplayName("Conditional Quantity")]
        [IsoXmlTag("CondlQty")]
        public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; }

        /// <summary>
        /// Quantity of securities to which this instruction applies.
        /// </summary>
        [IsoId("_qY_3u_fREeiNZp_PtLohLw")]
        [DisplayName("Instructed Quantity")]
        [IsoXmlTag("InstdQty")]
        public required Quantity40Choice_ InstructedQuantity { get; init; }

        /// <summary>
        /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
        /// </summary>
        [IsoId("_qY_3vffREeiNZp_PtLohLw")]
        [DisplayName("Additional Round Up Quantity")]
        [IsoXmlTag("AddtlRndUpQty")]
        public FinancialInstrumentQuantity15Choice_? AdditionalRoundUpQuantity { get; init; }
    }
}
