// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DatePeriod1Choice
{
    /// <summary>
    /// Time span defined by a start date and an end date.
    /// </summary>
    [IsoId("_-m9OxJ79EeOieb-y7x0pFg")]
    [DisplayName("From Date To Date")]
    public partial record FromDateToDate : DatePeriod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_T5oiAdp-Ed-ak6NoX_4Aeg_1497161242")]
        [DisplayName("From Date")]
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate FromDate { get; init; } 
        
        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_T5oiAtp-Ed-ak6NoX_4Aeg_1497161560")]
        [DisplayName("To Date")]
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ToDate { get; init; } 
        
        
        #nullable disable
        
    }
}
