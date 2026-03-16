// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount3Choice
{
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_nkqqYdNPEee-r40DhxXRmg")]
    [DisplayName("Securities Quantity")]
    public record SecuritiesQuantity : SecuritiesQuantityOrAmount3Choice_
    {
        /// <summary>
        /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
        /// </summary>
        [IsoId("_A9VktUGUEeWqy4niLuXETA")]
        [DisplayName("Conditional Quantity")]
        [IsoXmlTag("CondlQty")]
        public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; }

        /// <summary>
        /// Quantity of securities to which this instruction applies.
        /// </summary>
        [IsoId("_fHSboWOSEeW4z96Yfj3Wng")]
        [DisplayName("Instructed Quantity")]
        [IsoXmlTag("InstdQty")]
        public required Quantity20Choice_ InstructedQuantity { get; init; }
    }
}
