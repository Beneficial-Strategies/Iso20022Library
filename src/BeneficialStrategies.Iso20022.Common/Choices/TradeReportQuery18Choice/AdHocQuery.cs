// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery18Choice
{
    /// <summary>
    /// Ad Hoc Query.
    /// </summary>
    [DisplayName("Ad Hoc Query")]
    public partial record AdHocQuery : TradeReportQuery18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AdHocQry")]
        public required TradeQueryCriteria14 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
