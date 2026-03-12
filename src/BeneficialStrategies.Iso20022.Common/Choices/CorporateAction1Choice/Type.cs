// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateAction1Choice
{
    /// <summary>
    /// Corporate action event type expressed as a code.
    /// </summary>
    [IsoId("_1AYR4Qf_EeSaceXTzyiZRg")]
    [DisplayName("Type")]
    public partial record Type : CorporateAction1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action event.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required CorporateActionEventType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
