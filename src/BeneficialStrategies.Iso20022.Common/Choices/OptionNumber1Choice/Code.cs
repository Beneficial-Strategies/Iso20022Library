// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionNumber1Choice
{
    /// <summary>
    /// Code identifying special corporate action option numbers.
    /// </summary>
    [IsoId("_Q1O849p-Ed-ak6NoX_4Aeg_474199627")]
    [DisplayName("Code")]
    public partial record Code : OptionNumber1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code identifying special corporate action option numbers.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionNumber1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
