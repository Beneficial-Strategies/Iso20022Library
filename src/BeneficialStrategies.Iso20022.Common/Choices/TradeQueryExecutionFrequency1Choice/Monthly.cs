// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeQueryExecutionFrequency1Choice
{
    /// <summary>
    /// Query is executed on a monthly basis. The day of the month of the query execution should be specified.
    /// </summary>
    [IsoId("_mmTLsNGYEeaQk737TH1Fzw")]
    [DisplayName("Monthly")]
    public partial record Monthly : TradeQueryExecutionFrequency1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number (max 999) of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("Mnthly")]
        [IsoSimpleType(IsoSimpleType.Max3Number)]
        public required IsoMax3Number Value { get; init; } 
        
        
        #nullable disable
        
    }
}
