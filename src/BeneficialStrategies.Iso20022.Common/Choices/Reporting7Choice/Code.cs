// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reporting7Choice
{
    /// <summary>
    /// Third party reporting information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_vZnKgTxJEeW5v6FXICU4Ew")]
    [DisplayName("Code")]
    public partial record Code : Reporting7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies to which institution the reporting must be done.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Reporting1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
