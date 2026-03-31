// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DatePeriod1Choice
{
    /// <summary>
    /// Time span defined by a month and a year.
    /// </summary>
    [IsoId("_kaGgVZ79EeOieb-y7x0pFg")]
    [DisplayName("Date Month")]
    public record DateMonth : DatePeriod1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Month within a particular calendar year represented by YYYY-MM (ISO 8601).
        /// </summary>
        [IsoXmlTag("DtMnth")]
        [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
        public required IsoISOYearMonth Value { get; init; }
    }
}
