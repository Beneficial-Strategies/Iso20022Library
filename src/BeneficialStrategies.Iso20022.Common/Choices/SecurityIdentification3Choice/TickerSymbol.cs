// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, eg, RTR.L for Reuters quoted in London.
    /// </summary>
    [IsoId("_Qdr_lNp-Ed-ak6NoX_4Aeg_1064399370")]
    [DisplayName("Ticker Symbol")]
    public record TickerSymbol : SecurityIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, for example, RTR.L for Reuters quoted in London.
        /// </summary>
        [IsoXmlTag("TckrSymb")]
        [IsoSimpleType(IsoSimpleType.TickerIdentifier)]
        public required IsoTickerIdentifier Value { get; init; }
    }
}
