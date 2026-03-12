// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlaceOrUnderConfirmationChoice1
{
    /// <summary>
    /// Party to which the presentation is to be made.
    /// </summary>
    [IsoId("_97kuE3ltEeG7BsjMvd1mEw_-1053470050")]
    [DisplayName("Place Of Presentation")]
    public partial record PlaceOfPresentation : PlaceOrUnderConfirmationChoice1_
    {
        #nullable enable
        
        /// <summary>
        /// Place of the presentation.
        /// </summary>
        [IsoId("_97RzJHltEeG7BsjMvd1mEw_-404426889")]
        [DisplayName("Place")]
        [IsoXmlTag("Plc")]
        public required ExternalTypeOfParty1Code Place { get; init; } 
        
        /// <summary>
        /// Country where a presentation is to be made.
        /// </summary>
        [IsoId("_97RzJXltEeG7BsjMvd1mEw_392011712")]
        [DisplayName("Country")]
        [IsoXmlTag("Ctry")]
        public CountryCode? Country { get; init; } 
        
        
        #nullable disable
        
    }
}
