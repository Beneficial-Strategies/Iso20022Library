// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ActivityIndicator1Choice
{
    /// <summary>
    /// ISIC Identifier.
    /// </summary>
    [DisplayName("ISIC Identifier")]
    public partial record ISICIdentifier : ActivityIndicator1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ISICIdr")]
        public required IsoISICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
