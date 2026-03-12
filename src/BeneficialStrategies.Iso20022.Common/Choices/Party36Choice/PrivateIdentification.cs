// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party36Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_2uFgE-WkEeevU7McUP3D1w")]
    [DisplayName("Private Identification")]
    public partial record PrivateIdentification : Party36Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_pYxEw-WkEeevU7McUP3D1w")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
        
        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_pYxExeWkEeevU7McUP3D1w")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericPersonIdentification1? Other { get; init; } 
        
        
        #nullable disable
        
    }
}
