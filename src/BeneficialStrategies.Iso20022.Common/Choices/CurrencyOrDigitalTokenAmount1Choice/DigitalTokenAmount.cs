// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrencyOrDigitalTokenAmount1Choice
{
    /// <summary>
    /// Amount specified as a non-ISO currency (ISO 4217).
    /// </summary>
    [IsoId("_JFyZAANiEe2-vqzwMUAewg")]
    [DisplayName("Digital Token Amount")]
    public partial record DigitalTokenAmount : CurrencyOrDigitalTokenAmount1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the digital token identifier (DTI).
        /// </summary>
        [IsoId("_XQvb0ANiEe2-vqzwMUAewg")]
        [DisplayName("Identifier")]
        [IsoXmlTag("Idr")]
        [IsoSimpleType(IsoSimpleType.DTI2021Identifier)]
        public IsoDTI2021Identifier? Identifier { get; init; } 
        
        /// <summary>
        /// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
        /// </summary>
        [IsoId("_dmVr8QNiEe2-vqzwMUAewg")]
        [DisplayName("Unit")]
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.Max30DecimalNumber)]
        public required IsoMax30DecimalNumber Unit { get; init; } 
        
        /// <summary>
        /// Provides a description of the digital token identifier.
        /// </summary>
        [IsoId("_FY9sgANjEe2-vqzwMUAewg")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max30Text)]
        public IsoMax30Text? Description { get; init; } 
        
        
        #nullable disable
        
    }
}
