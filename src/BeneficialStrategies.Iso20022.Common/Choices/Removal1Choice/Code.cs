// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Removal1Choice
{
    /// <summary>
    /// Specifies the removal processing change requested expressed as a code.
    /// </summary>
    [IsoId("_xeEJoPkREeicy5Zn42b9bg")]
    [DisplayName("Code")]
    public partial record Code : Removal1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the removal process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FinancialInstrumentRemoval1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
