// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentType1Choice
{
    /// <summary>
    /// Document type in a coded form.
    /// </summary>
    [IsoId("_T3sBRtp-Ed-ak6NoX_4Aeg_174928147")]
    [DisplayName("Code")]
    public partial record Code : ReferredDocumentType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of financial or commercial document.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DocumentType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
