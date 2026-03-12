// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TechnicalIdentification1Choice
{
    /// <summary>
    /// Technical address of the party is defined in a free text format.
    /// </summary>
    [IsoId("_kpLGoe5NEeCisYr99QEiWA_1921350495")]
    [DisplayName("Technical Address")]
    public partial record TechnicalAddress : TechnicalIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 256 characters.
        /// </summary>
        [IsoXmlTag("TechAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public required IsoMax256Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
