// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode21Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_b52h0UENEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public partial record Code : DateCode21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
