// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReturnExcessCash1Choice
{
    /// <summary>
    /// Return excess cash type expressed as a code.
    /// </summary>
    [IsoId("_UN9QYALpEeutW5-TpeYJhA")]
    [DisplayName("Code")]
    public partial record Code : ReturnExcessCash1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies information about excess cash.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ReturnExcessCash1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
