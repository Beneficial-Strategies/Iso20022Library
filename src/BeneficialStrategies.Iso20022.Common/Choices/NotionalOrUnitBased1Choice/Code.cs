// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NotionalOrUnitBased1Choice
{
    /// <summary>
    /// Type of unit basis for a financial instrument expressed as a code.
    /// </summary>
    [IsoId("_EltSQJ9WEeqxTNfi5y7ywQ")]
    [DisplayName("Code")]
    public partial record Code : NotionalOrUnitBased1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the unit basis of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NotionalOrUnitBased1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
