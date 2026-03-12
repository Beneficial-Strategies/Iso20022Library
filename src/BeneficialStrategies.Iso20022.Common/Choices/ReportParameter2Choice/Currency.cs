// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportParameter2Choice
{
    /// <summary>
    /// Currency for which the estimated cash flow is being reported.
    /// </summary>
    [IsoId("_U1-1gtp-Ed-ak6NoX_4Aeg_-922147042")]
    [DisplayName("Currency")]
    public partial record Currency : ReportParameter2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
        /// </summary>
        [IsoXmlTag("Ccy")]
        public required ActiveOrHistoricCurrencyCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
