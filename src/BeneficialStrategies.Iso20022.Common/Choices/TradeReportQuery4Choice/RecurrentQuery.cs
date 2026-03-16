// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery4Choice
{
    /// <summary>
    /// Query criteria specifically applied to recurrent queries.
    /// </summary>
    [IsoId("_QH0wc4eAEei-Poi-FosJdw")]
    [DisplayName("Recurrent Query")]
    [IsoXmlTag("RcrntQry")]
    public record RecurrentQuery : TradeReportQuery4Choice_
    {
        /// <summary>
        /// Defines the type of recurrent query which is requested.
        /// </summary>
        [IsoId("_QV1XQYeAEei-Poi-FosJdw")]
        [DisplayName("Query Type")]
        [IsoXmlTag("QryTp")]
        [IsoSimpleType(IsoSimpleType.Max1000Text)]
        [StringLength(maximumLength: 1000, MinimumLength = 1)]
        public required IsoMax1000Text QueryType { get; init; }

        /// <summary>
        /// Defines the requested frequency of the recurrent query.
        /// </summary>
        [IsoId("_QV1XQ4eAEei-Poi-FosJdw")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public required TradeQueryExecutionFrequency1Choice_ Frequency { get; init; }

        /// <summary>
        /// Defines the date until which the query will be executed.
        /// </summary>
        [IsoId("_QV1XRYeAEei-Poi-FosJdw")]
        [DisplayName("Valid Until")]
        [IsoXmlTag("VldUntil")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ValidUntil { get; init; }
    }
}
