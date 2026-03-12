// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LinkageType1Choice
{
    /// <summary>
    /// Linkage type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtyREtp-Ed-ak6NoX_4Aeg_-1832047280")]
    [DisplayName("Code")]
    public partial record Code : LinkageType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of linkage requested.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LinkageType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
