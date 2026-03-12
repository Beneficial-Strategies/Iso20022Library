// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode9Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_QnElENp-Ed-ak6NoX_4Aeg_186332043")]
    [DisplayName("Code")]
    public partial record Code : DateCode9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is open.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
