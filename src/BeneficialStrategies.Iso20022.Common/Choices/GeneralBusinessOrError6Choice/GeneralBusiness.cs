// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessOrError6Choice
{
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_Mg4II5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business")]
    [IsoXmlTag("GnlBiz")]
    public record GeneralBusiness : GeneralBusinessOrError6Choice_
    {
        /// <summary>
        /// Further information about the criticality or importance of a general business information system.
        /// </summary>
        [IsoId("_MpLIgZlgEeeE1Ya-LgRsuQ")]
        [DisplayName("Qualifier")]
        [IsoXmlTag("Qlfr")]
        public InformationQualifierType1? Qualifier { get; init; }

        /// <summary>
        /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
        /// </summary>
        [IsoId("_MpLIg5lgEeeE1Ya-LgRsuQ")]
        [DisplayName("Subject")]
        [IsoXmlTag("Sbjt")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Subject { get; init; }

        /// <summary>
        /// General business information, in unstructured form.
        /// </summary>
        [IsoId("_MpLIhZlgEeeE1Ya-LgRsuQ")]
        [DisplayName("Subject Details")]
        [IsoXmlTag("SbjtDtls")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? SubjectDetails { get; init; }
    }
}
