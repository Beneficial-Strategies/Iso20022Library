// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat52Choice
{
    /// <summary>
    /// Digital Ledger Identification.
    /// </summary>
    [DisplayName("Digital Ledger Identification")]
    public partial record DigitalLedgerIdentification : SafekeepingPlaceFormat52Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DgtlLdgrId")]
        public required IsoDTI2024Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
