// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference16Choice
{
    /// <summary>
    /// Instructing Party Transaction Identification.
    /// </summary>
    [DisplayName("Instructing Party Transaction Identification")]
    public partial record InstructingPartyTransactionIdentification : IdentificationReference16Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("InstgPtyTxId")]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
