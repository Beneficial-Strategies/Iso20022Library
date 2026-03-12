// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AuditTrailOrBusinessError6Choice
{
    /// <summary>
    /// Business error resulting from a rejection.
    /// </summary>
    [IsoId("_bcWXk2c-EemvNLufWGIVOQ")]
    [DisplayName("Business Error")]
    public partial record BusinessError : AuditTrailOrBusinessError6Choice_
    {
        #nullable enable
        
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
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? Description { get; init; } 
        
        
        #nullable disable
        
    }
}
