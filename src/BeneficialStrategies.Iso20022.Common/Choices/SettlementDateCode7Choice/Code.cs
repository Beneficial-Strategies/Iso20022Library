// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementDateCode7Choice
{
    /// <summary>
    /// Settlement date expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_cU5zITqLEeWVrPy0StzzSg")]
    [DisplayName("Code")]
    public partial record Code : SettlementDateCode7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the date of settlement, in coded form.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementDate4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
