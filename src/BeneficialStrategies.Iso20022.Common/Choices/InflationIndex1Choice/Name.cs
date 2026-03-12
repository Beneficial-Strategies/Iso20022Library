// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InflationIndex1Choice
{
    /// <summary>
    /// Standardised name of the index.
    /// </summary>
    [IsoId("_ZyZ21yS2EeWsI5Sp3-B3zg")]
    [DisplayName("Name")]
    public partial record Name : InflationIndex1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 25 characters.
        /// </summary>
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        public required IsoMax25Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
