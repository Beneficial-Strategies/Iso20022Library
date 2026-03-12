// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementConditionModificationStatus4Choice
{
    /// <summary>
    /// Provides the status of the securities settlement condition modification request.
    /// </summary>
    [IsoId("_8QcPy5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : SettlementConditionModificationStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a securities settlement condition modification request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementConditionModificationStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
