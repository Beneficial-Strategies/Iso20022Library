// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IsabelInputSource1Choice
{
    /// <summary>
    /// Input source for the generation of the file, in a coded form.
    /// </summary>
    [IsoId("_SG0RYsmMEeWAGphE2LvqeA")]
    [DisplayName("Code")]
    public partial record Code : IsabelInputSource1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the input source for the generation of the file.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InputSource1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
