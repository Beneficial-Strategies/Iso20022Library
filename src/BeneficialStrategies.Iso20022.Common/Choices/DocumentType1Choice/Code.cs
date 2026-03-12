// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DocumentType1Choice
{
    /// <summary>
    /// Document type, in a coded form.
    /// </summary>
    [IsoId("_iYH70HiJEeidzqjNEfehPg")]
    [DisplayName("Code")]
    public partial record Code : DocumentType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the document type as published in an external document type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDocumentType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
