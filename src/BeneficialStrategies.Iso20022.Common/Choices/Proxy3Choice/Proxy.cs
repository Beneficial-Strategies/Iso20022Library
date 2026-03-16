// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Proxy3Choice
{
    /// <summary>
    /// Proxy assignment and registration information.
    /// </summary>
    [IsoId("_kQJ7Ia09EemDtrWpq90Ckg")]
    [DisplayName("Proxy")]
    public record Proxy : Proxy3Choice_
    {
        /// <summary>
        /// Specifies how to register the proxy.
        /// </summary>
        [IsoId("_kmLOc609EemDtrWpq90Ckg")]
        [DisplayName("Registration Method")]
        [IsoXmlTag("RegnMtd")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? RegistrationMethod { get; init; }

        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the intermediary.
        /// </summary>
        [IsoId("_kmLOda09EemDtrWpq90Ckg")]
        [DisplayName("Deadline")]
        [IsoXmlTag("Ddln")]
        public DateFormat58Choice_? Deadline { get; init; }

        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the issuer.
        /// </summary>
        [IsoId("_kmLOea09EemDtrWpq90Ckg")]
        [DisplayName("Market Deadline")]
        [IsoXmlTag("MktDdln")]
        public DateFormat58Choice_? MarketDeadline { get; init; }

        /// <summary>
        /// Proxy person that is authorised by the issuer.
        /// </summary>
        [IsoId("_kmLOe609EemDtrWpq90Ckg")]
        [DisplayName("Authorised Proxy")]
        [IsoXmlTag("AuthrsdPrxy")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Proxy8> AuthorisedProxy { get; init; } = [];
    }
}
