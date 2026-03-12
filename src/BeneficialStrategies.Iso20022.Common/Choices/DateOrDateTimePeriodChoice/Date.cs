// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriodChoice
{
    /// <summary>
    /// Period expressed with dates.
    /// </summary>
    [IsoId("_T6Em7dp-Ed-ak6NoX_4Aeg_-1600112397")]
    [DisplayName("Date")]
    public partial record Date : DateOrDateTimePeriodChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Start date of the range.
        /// </summary>
        [IsoId("_T-soN9p-Ed-ak6NoX_4Aeg_330596075")]
        [DisplayName("From Date")]
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate FromDate { get; init; } 
        
        /// <summary>
        /// End date of the range.
        /// </summary>
        [IsoId("_T-soONp-Ed-ak6NoX_4Aeg_330596076")]
        [DisplayName("To Date")]
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ToDate { get; init; } 
        
        
        #nullable disable
        
    }
}
