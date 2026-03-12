// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References71Choice
{
    /// <summary>
    /// Unambiguous identification of the triparty collateral transaction instruction status advice to be cancelled.
    /// </summary>
    [IsoId("_KDxv0SAaEeu4a6pNulzZ4Q")]
    [DisplayName("Triparty Collateral Transaction Instruction Processing Status Advice Identification")]
    public partial record TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification : References71Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("TrptyCollTxInstrPrcgStsAdvcId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
