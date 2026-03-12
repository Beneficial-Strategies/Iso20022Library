// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification6Choice
{
    /// <summary>
    /// Identification of the payment instruction by its position in a queue managed by the clearing agent.
    /// </summary>
    [IsoId("_Aghbk24-EeiU9cctagi5ow")]
    [DisplayName("Queue Identification")]
    public partial record QueueIdentification : PaymentIdentification6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the payment queue where the payment instruction resides.
        /// </summary>
        [IsoXmlTag("QId")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoMax16Text Value { get; init; } 
        
        /// <summary>
        /// Position of the payment instruction within the identified queue.
        /// </summary>
        [IsoId("_X8kio5lQEee-Zps0fZQaFQ")]
        [DisplayName("Position In Queue")]
        [IsoXmlTag("PosInQ")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoMax16Text PositionInQueue { get; init; } 
        
        
        #nullable disable
        
    }
}
