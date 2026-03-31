// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LotteryType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the lottery type.
    /// </summary>
    [IsoId("_Rms2Ftp-Ed-ak6NoX_4Aeg_-924254404")]
    [DisplayName("Code")]
    public record Code : LotteryType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of lottery.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LotteryType1Code Value { get; init; }
    }
}
