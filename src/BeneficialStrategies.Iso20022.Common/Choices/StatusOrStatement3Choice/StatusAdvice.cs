// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement3Choice
{
    /// <summary>
    /// Identify the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_CEn-0fJlEd-DocZblYEqZw")]
    [DisplayName("Status Advice")]
    public record StatusAdvice : StatusOrStatement3Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_D2Ul8_JlEd-DocZblYEqZw")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber1Choice_ Number { get; init; }

        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_D2Ul9fJlEd-DocZblYEqZw")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification7> References { get; init; } = [];
        // ID for the above is _D2Ul9fJlEd-DocZblYEqZw
    }
}
