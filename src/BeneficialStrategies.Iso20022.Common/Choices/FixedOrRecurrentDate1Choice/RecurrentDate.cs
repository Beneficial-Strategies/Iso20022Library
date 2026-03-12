// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FixedOrRecurrentDate1Choice
{
    /// <summary>
    /// Details related to recurrent dates on which the variation is triggered.
    /// </summary>
    [IsoId("_98U8AXltEeG7BsjMvd1mEw_-1677013285")]
    [DisplayName("Recurrent Date")]
    public partial record RecurrentDate : FixedOrRecurrentDate1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date on which a recurrent date will commence.
        /// </summary>
        [IsoId("_98LLA3ltEeG7BsjMvd1mEw_-900960723")]
        [DisplayName("Start Date")]
        [IsoXmlTag("StartDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate StartDate { get; init; } 
        
        /// <summary>
        /// Specifies the regularity of the trigger date.
        /// </summary>
        [IsoId("_98LLBHltEeG7BsjMvd1mEw_-1516871632")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public required ExternalDateFrequency1Code Frequency { get; init; } 
        
        /// <summary>
        /// Maximum number of trigger date occurrence cycles.
        /// </summary>
        [IsoId("_98LLBXltEeG7BsjMvd1mEw_-1181408529")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Number { get; init; } 
        
        
        #nullable disable
        
    }
}
