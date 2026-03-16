// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceSubType1Choice
{
    /// <summary>
    /// Balance sub-type, as published in an external balance sub-type code list.
    /// </summary>
    [IsoId("_SYoCRNp-Ed-ak6NoX_4Aeg_771530952")]
    [DisplayName("Code")]
    public record Code : BalanceSubType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the balance sub-type, as published in an external balance sub-type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalBalanceSubType1Code Value { get; init; }
    }
}
