// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification12Choice
{
    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_XMCG5Np-Ed-ak6NoX_4Aeg_1227787110")]
    [DisplayName("Other Identification")]
    public record OtherIdentification : SecurityIdentification12Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_W9bqPNp-Ed-ak6NoX_4Aeg_-1574658177")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax31Text)]
        [StringLength(maximumLength: 31, MinimumLength = 1)]
        public required IsoRestrictedFINXMax31Text Identification { get; init; }

        /// <summary>
        /// Source of the security identification.
        /// </summary>
        [IsoId("_W9k0INp-Ed-ak6NoX_4Aeg_-1624701768")]
        [DisplayName("Identification Source")]
        [IsoXmlTag("IdSrc")]
        public required IdentificationSource2Choice_ IdentificationSource { get; init; }
    }
}
