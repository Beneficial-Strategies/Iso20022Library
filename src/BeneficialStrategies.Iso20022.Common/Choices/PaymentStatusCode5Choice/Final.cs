// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode5Choice
{
    /// <summary>
    /// Qualifies further the final status.
    /// </summary>
    [IsoId("_72FYFKMgEeCJ6YNENx4h-w_-1507776848")]
    [DisplayName("Final")]
    public partial record Final : PaymentStatusCode5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the final status of a transaction.
        /// </summary>
        [IsoXmlTag("Fnl")]
        public required FinalStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
