// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity1Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QYn5atp-Ed-ak6NoX_4Aeg_-1819529328")]
    [DisplayName("Quantity As DSS")]
    [IsoXmlTag("QtyAsDSS")]
    public record QuantityAsDSS : SubBalanceQuantity1Choice_
    {
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_luUtp-Ed-ak6NoX_4Aeg_-1713450015")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8, MinimumLength = 1)]
        public required IsoMax8Text Issuer { get; init; }

        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P_luU9p-Ed-ak6NoX_4Aeg_-1801508836")]
        [DisplayName("Information")]
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText Information { get; init; }

        /// <summary>
        /// Value of the balance.
        /// </summary>
        [IsoId("_P_luVNp-Ed-ak6NoX_4Aeg_-1695902189")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Balance { get; init; }
    }
}
