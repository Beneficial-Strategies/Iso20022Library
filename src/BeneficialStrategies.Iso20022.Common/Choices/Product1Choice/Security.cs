// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Product1Choice
{
    /// <summary>
    /// Attributes relating to cleared securities.
    /// </summary>
    [IsoId("_QapNsLVQEeadLcJesEbkTQ")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public record Security : Product1Choice_
    {
        /// <summary>
        /// Specifies the ISIN of the collateral.
        /// </summary>
        [IsoId("_9iE2ILVYEeadLcJesEbkTQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public required IsoISINOct2015Identifier Identification { get; init; }

        /// <summary>
        /// Identifies the security issuer.
        /// </summary>
        [IsoId("_DnQrsLVZEeadLcJesEbkTQ")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Issuer { get; init; }

        /// <summary>
        /// Sector for the security issuer, for example, 0500.
        /// </summary>
        [IsoId("_Hr6M4LVZEeadLcJesEbkTQ")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        public IsoSNA2008SectorIdentifier? Sector { get; init; }
    }
}
