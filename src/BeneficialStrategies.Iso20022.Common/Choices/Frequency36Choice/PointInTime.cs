// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice
{
    /// <summary>
    /// Specifies a frequency in terms of an exact point in time or moment within a specified period type.
    /// </summary>
    [IsoId("_6IxUQWk2Eeanu6HLe77Rkg")]
    [DisplayName("Point In Time")]
    public partial record PointInTime : Frequency36Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Period for which the number of instructions are to be created and processed.
        /// </summary>
        [IsoId("_CWY19Wk3Eeanu6HLe77Rkg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required Frequency6Code Type { get; init; } 
        
        /// <summary>
        /// Further information on the exact point in time the event should take place.
        /// </summary>
        [IsoXmlTag("PtInTm")]
        [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
        public required IsoExact2NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
