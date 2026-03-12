// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod2Choice
{
    /// <summary>
    /// Period expressed with dates and times.
    /// </summary>
    [IsoId("_l61PQ7QVEeemgtANb5gbCw")]
    [DisplayName("Date Time")]
    public partial record DateTime : DateOrDateTimePeriod2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_JWX38a3NEeey8N0JWnVPUw")]
        [DisplayName("From Date Time")]
        [IsoXmlTag("FrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime FromDateTime { get; init; } 
        
        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_JWX3863NEeey8N0JWnVPUw")]
        [DisplayName("To Date Time")]
        [IsoXmlTag("ToDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ToDateTime { get; init; } 
        
        
        #nullable disable
        
    }
}
