// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Proxy5Choice
{
    /// <summary>
    /// Proxy assignment and registration information.
    /// </summary>
    [IsoId("_iTU-wRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy")]
    public record Proxy : Proxy5Choice_
    {
        /// <summary>
        /// Specifies how to register the proxy.
        /// </summary>
        [IsoId("_ioMbgxrfEeyhRdHRjakS2w")]
        [DisplayName("Registration Method")]
        [IsoXmlTag("RegnMtd")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? RegistrationMethod { get; init; }

        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the intermediary.
        /// </summary>
        [IsoId("_ioMbhRrfEeyhRdHRjakS2w")]
        [DisplayName("Deadline")]
        [IsoXmlTag("Ddln")]
        public DateFormat58Choice_? Deadline { get; init; }

        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the issuer.
        /// </summary>
        [IsoId("_ioMbhxrfEeyhRdHRjakS2w")]
        [DisplayName("Market Deadline")]
        [IsoXmlTag("MktDdln")]
        public DateFormat58Choice_? MarketDeadline { get; init; }

        /// <summary>
        /// Proxy person that is authorised by the issuer.
        /// </summary>
        [IsoId("_ioMbiRrfEeyhRdHRjakS2w")]
        [DisplayName("Authorised Proxy")]
        [IsoXmlTag("AuthrsdPrxy")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Proxy11> AuthorisedProxy { get; init; } = [];
    }
}
