// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode4Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_Q2uKptp-Ed-ak6NoX_4Aeg_284746717")]
    [DisplayName("Code")]
    public partial record Code : DateCode4Choice_
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
