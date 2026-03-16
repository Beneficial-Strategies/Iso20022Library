// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement1Choice
{
    /// <summary>
    /// Identify the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_QqNYotp-Ed-ak6NoX_4Aeg_-405761909")]
    [DisplayName("Status Advice")]
    public record StatusAdvice : StatusOrStatement1Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_Tg5R4Np-Ed-ak6NoX_4Aeg_171158802")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber1Choice_ Number { get; init; }

        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_Tg5R4dp-Ed-ak6NoX_4Aeg_-266260922")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification2> References { get; init; } = [];
        // ID for the above is _Tg5R4dp-Ed-ak6NoX_4Aeg_-266260922
    }
}
