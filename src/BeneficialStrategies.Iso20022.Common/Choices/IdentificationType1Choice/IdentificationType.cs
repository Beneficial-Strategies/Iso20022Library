// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationType1Choice
{
    /// <summary>
    /// Specifies a type of individual identification.
    /// </summary>
    [IsoId("_QAoQJ9p-Ed-ak6NoX_4Aeg_-1246497918")]
    [DisplayName("Identification Type")]
    public partial record IdentificationType : IdentificationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
        /// </summary>
        [IsoXmlTag("IdTp")]
        public required PersonIdentificationType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
