// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod1Choice
{
    /// <summary>
    /// Period expressed with dates.
    /// </summary>
    [IsoId("_RF6mMa6AEeexrtTFgmVD3Q")]
    [DisplayName("Date")]
    public partial record Date : DateOrDateTimePeriod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Start date of the range.
        /// </summary>
        [IsoId("_lhvG0YaDEee8r9VKRbnJSg")]
        [DisplayName("From Date")]
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate FromDate { get; init; } 
        
        /// <summary>
        /// End date of the range.
        /// </summary>
        [IsoId("_lhvG04aDEee8r9VKRbnJSg")]
        [DisplayName("To Date")]
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ToDate { get; init; } 
        
        
        #nullable disable
        
    }
}
