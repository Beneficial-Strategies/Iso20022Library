// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Proxy1Choice
{
    /// <summary>
    /// Specifies the elements required to assign a proxy.
    /// </summary>
    [IsoId("_RD1Zkdp-Ed-ak6NoX_4Aeg_2099927655")]
    [DisplayName("Proxy")]
    public record Proxy : Proxy1Choice_
    {
        /// <summary>
        /// Indicates how to register a proxy.
        /// </summary>
        [IsoId("_T4vKKtp-Ed-ak6NoX_4Aeg_-1494745964")]
        [DisplayName("Registration Method")]
        [IsoXmlTag("RegnMtd")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? RegistrationMethod { get; init; }

        /// <summary>
        /// Date by which the information on proxy assignment must be received by the intermediary.
        /// </summary>
        [IsoId("_T4vKK9p-Ed-ak6NoX_4Aeg_-1494745911")]
        [DisplayName("Deadline")]
        [IsoXmlTag("Ddln")]
        public DateFormat2Choice_? Deadline { get; init; }

        /// <summary>
        /// Date by which the information on proxy assignment must be received by the intermediary (STP mode).
        /// </summary>
        [IsoId("_T4vKLNp-Ed-ak6NoX_4Aeg_-1494745880")]
        [DisplayName("STP Deadline")]
        [IsoXmlTag("STPDdln")]
        public DateFormat2Choice_? STPDeadline { get; init; }

        /// <summary>
        /// Date by which the information on proxy assignment must be received by the issuer.
        /// </summary>
        [IsoId("_T4vKLdp-Ed-ak6NoX_4Aeg_-1494745571")]
        [DisplayName("Market Deadline")]
        [IsoXmlTag("MktDdln")]
        public DateFormat2Choice_? MarketDeadline { get; init; }

        /// <summary>
        /// Specifies the proxy persons which are authorised by the issuer.
        /// </summary>
        [IsoId("_T44UENp-Ed-ak6NoX_4Aeg_2026044451")]
        [DisplayName("Authorised Proxy")]
        [IsoXmlTag("AuthrsdPrxy")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Proxy3> AuthorisedProxy { get; init; } = [];
    }
}
