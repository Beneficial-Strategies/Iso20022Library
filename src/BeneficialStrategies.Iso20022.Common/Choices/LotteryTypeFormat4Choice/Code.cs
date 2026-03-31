// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LotteryTypeFormat4Choice
{
    /// <summary>
    /// Standard code to specify the type of lottery announced.
    /// </summary>
    [IsoId("_Yew_MUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : LotteryTypeFormat4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of lottery.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LotteryType1Code Value { get; init; }
    }
}
