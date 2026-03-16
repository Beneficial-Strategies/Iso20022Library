// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification3Choice
{
    /// <summary>
    /// Identification of the person that owns the account.
    /// </summary>
    [IsoId("_G6_50YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Identification Number")]
    [IsoXmlTag("IdNb")]
    public record IdentificationNumber : IndividualPersonIdentification3Choice_
    {
        /// <summary>
        /// Identification of a party, such as a tax or social security identifier.
        /// </summary>
        [IsoId("_ULIwYyFVEeWgV9SQSyaAog")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Type of identification.
        /// </summary>
        [IsoId("_hjcOQCFVEeWgV9SQSyaAog")]
        [DisplayName("Identification Type")]
        [IsoXmlTag("IdTp")]
        public required OtherIdentification3Choice_ IdentificationType { get; init; }
    }
}
