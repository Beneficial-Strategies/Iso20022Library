// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate9Choice
{
    /// <summary>
    /// Date expressed as a code.
    /// </summary>
    [IsoId("_qImeGc3yEee5nJBZsW8MFQ")]
    [DisplayName("Date Code")]
    public partial record DateCode : TradeDate9Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtCd")]
        public required TradeDateCode4Choice_ Value { get; init; }
    }
}
