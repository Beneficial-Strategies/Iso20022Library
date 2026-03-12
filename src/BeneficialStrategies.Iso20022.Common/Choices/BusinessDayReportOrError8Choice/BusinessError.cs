// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError8Choice
{
    /// <summary>
    /// Reason the requested business information is not given.
    /// </summary>
    [IsoId("_w64j45lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Error")]
    public partial record BusinessError : BusinessDayReportOrError8Choice_
    {
        #nullable enable
        
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
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? Description { get; init; } 
        
        
        #nullable disable
        
    }
}
