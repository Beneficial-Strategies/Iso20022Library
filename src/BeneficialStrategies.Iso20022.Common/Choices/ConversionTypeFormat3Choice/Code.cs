// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConversionTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the type of conversion.
    /// </summary>
    [IsoId("_1zCnAUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public partial record Code : ConversionTypeFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of conversion.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConversionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
