// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification6Choice
{
    /// <summary>
    /// Unique proprietary reference of the underlying payment instruction assigned by the system.
    /// </summary>
    [IsoId("_AghbmW4-EeiU9cctagi5ow")]
    [DisplayName("Proprietary Identification")]
    public partial record ProprietaryIdentification : PaymentIdentification6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 70characters.
        /// </summary>
        [IsoXmlTag("PrtryId")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public required IsoMax70Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
