// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeDateCode1Choice
{
    /// <summary>
    /// Trade date expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QvRe19p-Ed-ak6NoX_4Aeg_1498245170")]
    [DisplayName("Code")]
    public partial record Code : TradeDateCode1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
