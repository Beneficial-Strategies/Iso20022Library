// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EUCapitalGain3Choice
{
    /// <summary>
    /// EU capital gain expressed as a code.
    /// </summary>
    [IsoId("_6r67QTh7EeaH-93K5JKmzw")]
    [DisplayName("Code")]
    public record Code : EUCapitalGain3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EUCapitalGain2Code Value { get; init; }
    }
}
