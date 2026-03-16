// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification22Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_B03cA1hxEeWDI58xzGOTTQ")]
    [DisplayName("Alternate Identification")]
    public record AlternateIdentification : SecurityIdentification22Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_TBTL09p-Ed-ak6NoX_4Aeg_2021814610")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Source of the security identification.
        /// </summary>
        [IsoId("_TBTL1Np-Ed-ak6NoX_4Aeg_-1724730736")]
        [DisplayName("Identification Source")]
        [IsoXmlTag("IdSrc")]
        public required IdentificationSource1Choice_ IdentificationSource { get; init; }
    }
}
