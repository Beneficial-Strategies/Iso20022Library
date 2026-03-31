// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice
{
    /// <summary>
    /// Indicates that price or quantity is expressed in another notation.
    /// </summary>
    [IsoId("_gSTIjZjcEeqkLZLH6DK3UQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : SecuritiesTransactionPrice17Choice_
    {
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_U3LMM5jgEeqkLZLH6DK3UQ")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
        public IsoLongFraction19DecimalNumber? Value { get; init; }

        /// <summary>
        /// Notation of the price.
        /// </summary>
        [IsoId("_U3LMNZjgEeqkLZLH6DK3UQ")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Type { get; init; }
    }
}
