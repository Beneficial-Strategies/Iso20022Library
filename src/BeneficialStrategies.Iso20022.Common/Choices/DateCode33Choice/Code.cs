// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode33Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_d3GXAe3DEeqc-LCjwLsUVg")]
    [DisplayName("Code")]
    public partial record Code : DateCode33Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Date is specified as a fixed code value.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
