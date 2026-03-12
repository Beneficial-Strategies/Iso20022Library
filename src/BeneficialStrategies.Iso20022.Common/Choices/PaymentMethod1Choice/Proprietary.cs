// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentMethod1Choice
{
    /// <summary>
    /// Method of payment for the remittance of the CSD or the NCB to the invoicing party, in a proprietary free text format.
    /// </summary>
    [IsoId("_jFLkVO5NEeCisYr99QEiWA_1833674686")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : PaymentMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 210 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public required IsoMax210Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
