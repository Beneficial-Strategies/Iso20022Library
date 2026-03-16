// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferReason1Choice
{
    /// <summary>
    /// Transfer reason expressed as a proprietary code.
    /// </summary>
    [IsoId("_hvAgY651EeeMy7TnJ3e__g")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : TransferReason1Choice_
    {
        /// <summary>
        /// Identification assigned by an institution.
        /// </summary>
        [IsoId("_WelLBtp-Ed-ak6NoX_4Aeg_-1431823633")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Identification { get; init; }

        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_WelLB9p-Ed-ak6NoX_4Aeg_868998957")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public IsoMax4AlphaNumericText? SchemeName { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_WelLCNp-Ed-ak6NoX_4Aeg_573897572")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Issuer { get; init; }
    }
}
