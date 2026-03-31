// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError3Choice
{
    /// <summary>
    /// Indicates that an operational error has been issued during the processing of the related request.
    /// </summary>
    [IsoId("_M4MEo5lPEee-Zps0fZQaFQ")]
    [DisplayName("Operational Error")]
    [IsoXmlTag("OprlErr")]
    public record OperationalError : TransactionReportOrError3Choice_
    {
        /// <summary>
        /// Specification of the error, in coded or proprietary form.
        /// </summary>
        [IsoId("_jXcIMxbvEeOy-PlRuFSUzQ")]
        [DisplayName("Error")]
        [IsoXmlTag("Err")]
        public required ErrorHandling2Choice_ Error { get; init; }

        /// <summary>
        /// Specification of the error, in free format.
        /// </summary>
        [IsoId("_jXcINRbvEeOy-PlRuFSUzQ")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? Description { get; init; }
    }
}
