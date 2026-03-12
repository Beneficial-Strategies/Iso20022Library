// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PremiumQuote1Choice
{
    /// <summary>
    /// Premium calculation is based on points of the call amount.
    /// </summary>
    [IsoId("_TMLmItp-Ed-ak6NoX_4Aeg_-1552900268")]
    [DisplayName("Points Of Call Amount")]
    public partial record PointsOfCallAmount : PremiumQuote1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a decimal, for example, 0.7 is 7/10 and 70%.
        /// </summary>
        [IsoXmlTag("PtsOfCallAmt")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public required IsoBaseOneRate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
