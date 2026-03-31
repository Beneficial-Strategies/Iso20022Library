// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountPrice1Choice
{
    /// <summary>
    /// Amount expressed as a unit price.
    /// </summary>
    [IsoId("_VMB-Ctp-Ed-ak6NoX_4Aeg_1790266847")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public record UnitPrice : AmountPrice1Choice_
    {
        /// <summary>
        /// Type and information about a price.
        /// </summary>
        [IsoId("_U4glFdp-Ed-ak6NoX_4Aeg_-1484209806")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required TypeOfPrice8Code Type { get; init; }

        /// <summary>
        /// Value of the price, eg, as a currency and value.
        /// </summary>
        [IsoId("_U4glFtp-Ed-ak6NoX_4Aeg_-1484209805")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required PriceValue1 Value { get; init; }
    }
}
