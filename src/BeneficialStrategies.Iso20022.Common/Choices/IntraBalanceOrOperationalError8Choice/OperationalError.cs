// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError8Choice
{
    /// <summary>
    /// Operational error resulting from a rejection.
    /// </summary>
    [IsoId("_Z496kzneEem7JZMuWtwtsg")]
    [DisplayName("Operational Error")]
    [IsoXmlTag("OprlErr")]
    public record OperationalError : IntraBalanceOrOperationalError8Choice_
    {
        /// <summary>
        /// Specification of the error, in coded or proprietary form.
        /// </summary>
        [IsoId("_RA_78XhdEeidzqjNEfehPg")]
        [DisplayName("Error")]
        [IsoXmlTag("Err")]
        public required ErrorHandling3Choice_ Error { get; init; }

        /// <summary>
        /// Specification of the error, in free format.
        /// </summary>
        [IsoId("_RA_783hdEeidzqjNEfehPg")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? Description { get; init; }
    }
}
