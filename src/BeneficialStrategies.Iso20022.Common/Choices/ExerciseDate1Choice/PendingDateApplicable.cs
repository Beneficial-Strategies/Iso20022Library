// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExerciseDate1Choice
{
    /// <summary>
    /// Indicates that price is currently not available, but pending.
    /// </summary>
    [IsoId("_Y7c_swbBEeqrW7Meu5r3kQ")]
    [DisplayName("Pending Date Applicable")]
    public partial record PendingDateApplicable : ExerciseDate1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Status of the price of a financial instrument.
        /// </summary>
        [IsoXmlTag("PdgDtAplbl")]
        public required PriceStatus2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
