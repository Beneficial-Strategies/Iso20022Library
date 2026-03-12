// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError4Choice
{
    /// <summary>
    /// Reason the requested business information is not given.
    /// </summary>
    [IsoId("_MqM5QdfiEeqoweZZxm4TPQ")]
    [DisplayName("Business Error")]
    public partial record BusinessError : ExchangeRateReportOrError4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specification of the error, in coded or proprietary form.
        /// </summary>
        [IsoId("_RY_xStp-Ed-ak6NoX_4Aeg_-487033921")]
        [DisplayName("Error")]
        [IsoXmlTag("Err")]
        public required ErrorHandling1Choice_ Error { get; init; } 
        
        /// <summary>
        /// Specification of the error, in free format.
        /// </summary>
        [IsoId("_RZI7MNp-Ed-ak6NoX_4Aeg_-917396614")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? Description { get; init; } 
        
        
        #nullable disable
        
    }
}
