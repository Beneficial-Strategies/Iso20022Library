// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity2Choice
{
    /// <summary>
    /// Provides the period for the time to maturity.
    /// </summary>
    [IsoId("__aOTka5OEeuo-IflVgGqiA")]
    [DisplayName("Period")]
    public record Period : TimeToMaturity2Choice_
    {
        /// <summary>
        /// Specifies the start of the maturity period.
        /// </summary>
        [IsoId("__pHrMa5OEeuo-IflVgGqiA")]
        [DisplayName("Start")]
        [IsoXmlTag("Start")]
        public MaturityTerm2? Start { get; init; }

        /// <summary>
        /// Specifies the end of the maturity period.
        /// </summary>
        [IsoId("__pHrM65OEeuo-IflVgGqiA")]
        [DisplayName("End")]
        [IsoXmlTag("End")]
        public MaturityTerm2? End { get; init; }
    }
}
