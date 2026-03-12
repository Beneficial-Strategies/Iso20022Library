// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount1Choice
{
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_Gql3oIlYEeavwKddCbm3hg")]
    [DisplayName("Securities Quantity")]
    public partial record SecuritiesQuantity : SecuritiesQuantityOrAmount1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
        /// </summary>
        [IsoId("_cheM55KQEeWHWpTQn1FFVg")]
        [DisplayName("Conditional Quantity")]
        [IsoXmlTag("CondlQty")]
        public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; } 
        
        /// <summary>
        /// Quantity of securities to which this instruction applies.
        /// </summary>
        [IsoId("_cheM75KQEeWHWpTQn1FFVg")]
        [DisplayName("Instructed Quantity")]
        [IsoXmlTag("InstdQty")]
        public required Quantity40Choice_ InstructedQuantity { get; init; } 
        
        
        #nullable disable
        
    }
}
