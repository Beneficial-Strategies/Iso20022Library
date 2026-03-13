// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cancellation6Choice
{
    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_r0ZQUxwnEeOIveEnnb_1-A")]
    [DisplayName("Cancellation By Reference")]
    public partial record CancellationByReference : Cancellation6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_HzyxIS8FEeO59oUFO5eLvw")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; } 
        
        /// <summary>
        /// Transfer and cancellation reference.
        /// </summary>
        [IsoId("_HzyxIy8FEeO59oUFO5eLvw")]
        [DisplayName("Transfer References")]
        [IsoXmlTag("TrfRefs")]
        public ValueList<TransferReference8> TransferReferences { get; init; } = [];
        // ID for the above is _HzyxIy8FEeO59oUFO5eLvw
        
        
        #nullable disable
        
    }
}
