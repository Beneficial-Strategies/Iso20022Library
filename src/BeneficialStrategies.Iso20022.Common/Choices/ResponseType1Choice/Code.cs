// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseType1Choice
{
    /// <summary>
    /// Provides a margin call response type using an ISO 20022 code.
    /// </summary>
    [IsoId("_QnOWF9p-Ed-ak6NoX_4Aeg_1829122886")]
    [DisplayName("Code")]
    public partial record Code : ResponseType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarginCallResponse1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
