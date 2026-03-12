// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IsabelSenderTrigger1Choice
{
    /// <summary>
    /// Trigger used by the sender to generate the file, in a coded form.
    /// </summary>
    [IsoId("_bXfoAMmLEeWAGphE2LvqeA")]
    [DisplayName("Code")]
    public partial record Code : IsabelSenderTrigger1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the trigger code used by the sender to generate the file.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SenderTrigger1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
