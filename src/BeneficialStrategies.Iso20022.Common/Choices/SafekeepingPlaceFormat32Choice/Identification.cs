// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat32Choice
{
    /// <summary>
    /// Place of safekeeping expressed as a code and a narrative description.
    /// </summary>
    [IsoId("__2YuEffDEeiNZp_PtLohLw")]
    [DisplayName("Identification")]
    public partial record Identification : SafekeepingPlaceFormat32Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_cdSQFZKQEeWHWpTQn1FFVg")]
        [DisplayName("Safekeeping Place Type")]
        [IsoXmlTag("SfkpgPlcTp")]
        public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
        
        /// <summary>
        /// Additional information about the place of safekeeping.
        /// </summary>
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
        [StringLength(maximumLength: 30 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax30Text? Value { get; init; } 
        
        
        #nullable disable
        
    }
}
