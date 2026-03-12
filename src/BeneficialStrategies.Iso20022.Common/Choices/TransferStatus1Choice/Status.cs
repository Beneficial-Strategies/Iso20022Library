// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is received, accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_o1CqqBwkEeOIveEnnb_1-A")]
    [DisplayName("Status")]
    public partial record Status : TransferStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required TransferStatus3Code Value { get; init; } 
        
        /// <summary>
        /// Reason for the status.
        /// </summary>
        [IsoId("_ar5QVSGjEeONGJioFgcMDw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? Reason { get; init; } 
        
        
        #nullable disable
        
    }
}
