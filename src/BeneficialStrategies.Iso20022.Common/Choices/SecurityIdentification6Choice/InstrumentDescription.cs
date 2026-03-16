// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification6Choice
{
    /// <summary>
    /// Provides the ability to describe the instrument through a description and main characteristics.
    /// </summary>
    [IsoId("_TBKB8tp-Ed-ak6NoX_4Aeg_-1421894924")]
    [DisplayName("Instrument Description")]
    public record InstrumentDescription : SecurityIdentification6Choice_
    {
        /// <summary>
        /// Description of the security.
        /// </summary>
        [IsoId("_S1FUwNp-Ed-ak6NoX_4Aeg_1287302984")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Description { get; init; }

        /// <summary>
        /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
        /// </summary>
        [IsoId("_S1FUwdp-Ed-ak6NoX_4Aeg_1023322278")]
        [DisplayName("Classification Type")]
        [IsoXmlTag("ClssfctnTp")]
        public SecurityClassificationType1Choice_? ClassificationType { get; init; }

        /// <summary>
        /// Provides the place of listing using a market identifier code (MIC).
        /// </summary>
        [IsoId("_S1FUwtp-Ed-ak6NoX_4Aeg_1288222996")]
        [DisplayName("Place Of Listing")]
        [IsoXmlTag("PlcOfListg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? PlaceOfListing { get; init; }

        /// <summary>
        /// Exercise date/time of a derivative contract.
        /// </summary>
        [IsoId("_S1FUw9p-Ed-ak6NoX_4Aeg_1288223013")]
        [DisplayName("Exercise Date")]
        [IsoXmlTag("ExrcDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ExerciseDate { get; init; }

        /// <summary>
        /// Maturity date/time at which an interest bearing security becomes due.
        /// </summary>
        [IsoId("_S1FUxNp-Ed-ak6NoX_4Aeg_1288223031")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? MaturityDate { get; init; }

        /// <summary>
        /// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
        /// </summary>
        [IsoId("_S1FUxdp-Ed-ak6NoX_4Aeg_1288223048")]
        [DisplayName("Option Type")]
        [IsoXmlTag("OptnTp")]
        public OptionTypeCode? OptionType { get; init; }

        /// <summary>
        /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
        /// </summary>
        [IsoId("_S1FUxtp-Ed-ak6NoX_4Aeg_1288223066")]
        [DisplayName("Strike Price")]
        [IsoXmlTag("StrkPric")]
        public PriceRateOrAmountChoice_? StrikePrice { get; init; }

        /// <summary>
        /// Indicates the ratio or multiplying factor used to convert one contract into a quantity. In the case of an equity or a bond, the price multiplier is 1.
        /// </summary>
        [IsoId("_S1FUx9p-Ed-ak6NoX_4Aeg_1288223091")]
        [DisplayName("Multiplier")]
        [IsoXmlTag("Mltplr")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public IsoBaseOneRate? Multiplier { get; init; }
    }
}
