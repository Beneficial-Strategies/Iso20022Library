// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData1Choice
{
    /// <summary>
    /// Reference details on the underlying account.
    /// </summary>
    [IsoId("_CXmpZlRtEe23M4WgERMsYw")]
    [DisplayName("Account")]
    public record Account : UnderlyingData1Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_awzZ49cZEeqRFcf2R4bPBw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public AccountIdentification4Choice_? Identification { get; init; }

        /// <summary>
        /// Specifies the nature, or use of the account.
        /// </summary>
        [IsoId("_awzZ5dcZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public CashAccountType2Choice_? Type { get; init; }

        /// <summary>
        /// Identification of the currency in which the account is held. ||Usage: Currency should only be used in case one and the same account number covers several currencies|and the initiating party needs to identify which currency needs to be used for settlement on the account.
        /// </summary>
        [IsoId("_awzZ59cZEeqRFcf2R4bPBw")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveOrHistoricCurrencyCode? Currency { get; init; }

        /// <summary>
        /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
        /// </summary>
        [IsoId("_awzZ6dcZEeqRFcf2R4bPBw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public IsoMax70Text? Name { get; init; }

        /// <summary>
        /// Specifies an alternate assumed name for the identification of the account.
        /// </summary>
        [IsoId("_awzZ69cZEeqRFcf2R4bPBw")]
        [DisplayName("Proxy")]
        [IsoXmlTag("Prxy")]
        public ProxyAccountIdentification1? Proxy { get; init; }
    }
}
