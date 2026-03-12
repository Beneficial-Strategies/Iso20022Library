// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LotteryTypeFormat5Choice
{
    /// <summary>
    /// Standard code to specify the type of lottery announced.
    /// </summary>
    [IsoId("_cdS3g5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : LotteryTypeFormat5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of lottery.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LotteryType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
