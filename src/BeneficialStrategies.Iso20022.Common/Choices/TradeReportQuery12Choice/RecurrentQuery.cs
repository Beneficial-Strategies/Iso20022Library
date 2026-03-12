// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery12Choice
{
    /// <summary>
    /// Query criteria specifically applied to recurrent queries.
    /// </summary>
    [IsoId("_QG7io65pEeuo-IflVgGqiA")]
    [DisplayName("Recurrent Query")]
    public partial record RecurrentQuery : TradeReportQuery12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Defines the type of recurrent query which is requested.
        /// </summary>
        [IsoId("_et5Wsd1dEeqxpKDfBZC1vg")]
        [DisplayName("Query Type")]
        [IsoXmlTag("QryTp")]
        [IsoSimpleType(IsoSimpleType.Max1000Text)]
        [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
        public required IsoMax1000Text QueryType { get; init; } 
        
        /// <summary>
        /// Defines the requested frequency of the recurrent query.
        /// </summary>
        [IsoId("_et5Ws91dEeqxpKDfBZC1vg")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public required TradeQueryExecutionFrequency3 Frequency { get; init; } 
        
        /// <summary>
        /// Defines the date until which the query will be executed.
        /// </summary>
        [IsoId("_et5Wtd1dEeqxpKDfBZC1vg")]
        [DisplayName("Valid Until")]
        [IsoXmlTag("VldUntil")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ValidUntil { get; init; } 
        
        
        #nullable disable
        
    }
}
