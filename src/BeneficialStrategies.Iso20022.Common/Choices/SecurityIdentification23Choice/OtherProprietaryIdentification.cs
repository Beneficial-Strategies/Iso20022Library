// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_CSq4TyGQEeW7gKYhAMEFCw")]
    [DisplayName("Other Proprietary Identification")]
    [IsoXmlTag("OthrPrtryId")]
    public record OtherProprietaryIdentification : SecurityIdentification23Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_A7IS8yGPEeW7gKYhAMEFCw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Source of the identification, that is, domestic (national) or proprietary.
        /// </summary>
        [IsoId("_UwbpcCGPEeW7gKYhAMEFCw")]
        [DisplayName("Identification Source")]
        [IsoXmlTag("IdSrc")]
        public required IdentificationSource1Choice_ IdentificationSource { get; init; }
    }
}
