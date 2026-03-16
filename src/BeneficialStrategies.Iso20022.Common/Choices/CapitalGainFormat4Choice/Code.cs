// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CapitalGainFormat4Choice
{
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
    /// </summary>
    [IsoId("_c5V6qZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : CapitalGainFormat4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EUCapitalGain2Code Value { get; init; }
    }
}
