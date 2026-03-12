// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatusType1Choice
{
    /// <summary>
    /// Type of event expressed as a code.
    /// </summary>
    [IsoId("_GLJdEFNYEeijdq8ilaxyOA")]
    [DisplayName("Code")]
    public partial record Code : TransferStatusType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of transfer status or transfer event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransferStatusType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
