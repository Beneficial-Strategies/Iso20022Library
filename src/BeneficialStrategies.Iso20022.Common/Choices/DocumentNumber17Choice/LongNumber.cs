// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber17Choice
{
    /// <summary>
    /// MX Message identifier of the referenced document.
    /// </summary>
    [IsoId("_dPmxwZBgEeakHoV5BVecAQ")]
    [DisplayName("Long Number")]
    public partial record LongNumber : DocumentNumber17Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// ISO 20022 Message identifier of an MX message.
        /// </summary>
        [IsoXmlTag("LngNb")]
        [IsoSimpleType(IsoSimpleType.ISO20022MessageIdentificationText)]
        public required IsoISO20022MessageIdentificationText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
