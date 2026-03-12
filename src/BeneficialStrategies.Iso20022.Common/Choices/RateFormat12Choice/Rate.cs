// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateFormat12Choice
{
    /// <summary>
    /// Value is expressed as a rate.
    /// </summary>
    [IsoId("_uT61USqiEeObprHJy8Zrxg")]
    [DisplayName("Rate")]
    public partial record Rate : RateFormat12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a decimal, for example, 0.7 is 7/10 and 70% with 13 fractional digits maximum and 14 total digits.
        /// </summary>
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.BaseOne14Rate)]
        public required IsoBaseOne14Rate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
