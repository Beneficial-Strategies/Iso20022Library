// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode20Choice
{
    /// <summary>
    /// Standard code to indicate the date is unknown.
    /// </summary>
    [IsoId("_T9Q7MUEMEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public partial record Code : DateCode20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is unknown.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
