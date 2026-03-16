// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement3Choice
{
    /// <summary>
    /// Identify the statement/report that was requested.
    /// </summary>
    [IsoId("_CEn-0_JlEd-DocZblYEqZw")]
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement3Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_Tg5R5tp-Ed-ak6NoX_4Aeg_160411897")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber1Choice_ Number { get; init; }
    }
}
