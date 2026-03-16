// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification80Choice
{
    /// <summary>
    /// MSISDN.
    /// </summary>
    [DisplayName("MSISDN")]
    public partial record MSISDN : AccountIdentification80Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MSISDN")]
        public required IsoMax16Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
