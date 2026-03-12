// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LotteryType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the lottery type.
    /// </summary>
    [IsoId("_Rms2Ftp-Ed-ak6NoX_4Aeg_-924254404")]
    [DisplayName("Code")]
    public partial record Code : LotteryType1FormatChoice_
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
