// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError3Choice
{
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_MmlkkdfiEeqoweZZxm4TPQ")]
    [DisplayName("Currency Exchange Report")]
    public partial record CurrencyExchangeReport : ExchangeRateReportOrError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Source and target currencies for which information is request.
        /// </summary>
        [IsoId("_MobXodfiEeqoweZZxm4TPQ")]
        [DisplayName("Currency Reference")]
        [IsoXmlTag("CcyRef")]
        public required CurrencySourceTarget1 CurrencyReference { get; init; } 
        
        /// <summary>
        /// Reports either on currency exchange information or on a business error.
        /// </summary>
        [IsoId("_MobXo9fiEeqoweZZxm4TPQ")]
        [DisplayName("Currency Exchange Or Error")]
        [IsoXmlTag("CcyXchgOrErr")]
        public required ExchangeRateReportOrError4Choice_ CurrencyExchangeOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
