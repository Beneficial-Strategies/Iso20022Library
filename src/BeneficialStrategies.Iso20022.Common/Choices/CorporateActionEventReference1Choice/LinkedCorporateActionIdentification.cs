// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventReference1Choice
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
    /// </summary>
    [IsoId("_QxXJgNp-Ed-ak6NoX_4Aeg_-1898428206")]
    [DisplayName("Linked Corporate Action Identification")]
    public partial record LinkedCorporateActionIdentification : CorporateActionEventReference1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("LkdCorpActnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
