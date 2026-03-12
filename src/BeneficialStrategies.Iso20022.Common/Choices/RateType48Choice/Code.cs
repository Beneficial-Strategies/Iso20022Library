// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateType48Choice
{
    /// <summary>
    /// Standard code to specify the type of tax rate.
    /// </summary>
    [IsoId("_ckCY7pKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : RateType48Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
