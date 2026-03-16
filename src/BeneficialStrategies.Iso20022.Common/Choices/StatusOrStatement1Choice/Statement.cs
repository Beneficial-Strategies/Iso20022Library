// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement1Choice
{
    /// <summary>
    /// Identify the statement/report that was requested.
    /// </summary>
    [IsoId("_QqNYo9p-Ed-ak6NoX_4Aeg_-1264636374")]
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement1Choice_
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
