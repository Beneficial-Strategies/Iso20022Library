// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the type of taxes.
    /// </summary>
    [IsoId("_SumZEwEcEeCQm6a_G2yO_w_931213658")]
    [DisplayName("Code")]
    public partial record Code : TaxTypeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType15Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
