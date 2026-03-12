// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Date1Choice
{
    /// <summary>
    /// Date is defined using a code.
    /// </summary>
    [IsoId("_Q-niYNp-Ed-ak6NoX_4Aeg_-1377076498")]
    [DisplayName("Code")]
    public partial record Code : Date1Choice_
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
