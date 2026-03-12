// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NDFOpeningFixing1Choice
{
    /// <summary>
    /// Reference of the opening confirmation provided on an NDF fixing instruction to link back to the original NDF opening confirmation.
    /// </summary>
    [IsoId("_cR-bwJUJEeak6e8_Fc5fQg")]
    [DisplayName("Opening Confirmation Reference")]
    public partial record OpeningConfirmationReference : NDFOpeningFixing1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("OpngConfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
