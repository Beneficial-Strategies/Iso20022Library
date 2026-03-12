// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeliveryInterconnectionPoint1Choice
{
    /// <summary>
    /// Identification of delivery/interconnection point or zone in a proprietary format.
    /// </summary>
    [IsoId("_s36_sIOsEeWqmeP8QNJBew")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : DeliveryInterconnectionPoint1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
