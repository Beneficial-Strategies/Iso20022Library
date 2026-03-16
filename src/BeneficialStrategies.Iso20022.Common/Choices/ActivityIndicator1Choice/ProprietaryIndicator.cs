// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ActivityIndicator1Choice
{
    /// <summary>
    /// Proprietary Indicator.
    /// </summary>
    [DisplayName("Proprietary Indicator")]
    public partial record ProprietaryIndicator : ActivityIndicator1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrtryInd")]
        public required GenericIdentification36 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
