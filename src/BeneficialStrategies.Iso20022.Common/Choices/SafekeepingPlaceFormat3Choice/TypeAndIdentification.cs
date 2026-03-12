// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat3Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a type and identification.
    /// </summary>
    [IsoId("_SfoCIdp-Ed-ak6NoX_4Aeg_-955186209")]
    [DisplayName("Type And Identification")]
    public partial record TypeAndIdentification : SafekeepingPlaceFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_Shax49p-Ed-ak6NoX_4Aeg_1122224462")]
        [DisplayName("Safekeeping Place Type")]
        [IsoXmlTag("SfkpgPlcTp")]
        public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
        
        /// <summary>
        /// Place of safekeeping.
        /// </summary>
        [IsoId("_Shax5Np-Ed-ak6NoX_4Aeg_1122224574")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
