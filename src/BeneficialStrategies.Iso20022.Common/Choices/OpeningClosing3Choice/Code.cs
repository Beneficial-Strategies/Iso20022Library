// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OpeningClosing3Choice
{
    /// <summary>
    /// Opening closing information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_hE31ETtCEeWRTLSN0i0tng")]
    [DisplayName("Code")]
    public partial record Code : OpeningClosing3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information relative to the processing of the trade.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OpeningClosing1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
