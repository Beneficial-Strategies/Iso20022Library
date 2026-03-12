// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdjustmentType1Choice
{
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
    /// </summary>
    [IsoId("_POBygBrXEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    public partial record Type : AdjustmentType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of adjustment.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required AdjustmentType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
