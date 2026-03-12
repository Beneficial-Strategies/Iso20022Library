// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice4Choice
{
    /// <summary>
    /// Captures where no price is yet known.
    /// </summary>
    [IsoId("_8RdkgOI-EeWWKb0jFHxViQ")]
    [DisplayName("No Price")]
    public partial record NoPrice : SecuritiesTransactionPrice4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Price is currently not available, but pending.
        /// </summary>
        [IsoId("_lr-v8OI_EeWWKb0jFHxViQ")]
        [DisplayName("Pending")]
        [IsoXmlTag("Pdg")]
        public required PriceStatus1Code Pending { get; init; } 
        
        /// <summary>
        /// Currency that will be used but for which no price is yet known.
        /// </summary>
        [IsoId("_tbdkIOI_EeWWKb0jFHxViQ")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
        
        
        #nullable disable
        
    }
}
