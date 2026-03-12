// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is received, accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_WY1VQeijEeuLe8v4JEtDDg")]
    [DisplayName("Status")]
    public partial record Status : TransferStatus5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required TransferStatus6Code Value { get; init; } 
        
        /// <summary>
        /// Reason for the status.
        /// </summary>
        [IsoId("_avAfhVNUEeijdq8ilaxyOA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? Reason { get; init; } 
        
        
        #nullable disable
        
    }
}
