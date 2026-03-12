// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Period6Choice
{
    /// <summary>
    /// Time span defined by a start date and time, and an end date and time.
    /// </summary>
    [IsoId("_joeDs7QYEeeKRKrD60ELBQ")]
    [DisplayName("Period")]
    public partial record Period : Period6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_j3y5I7QYEeeKRKrD60ELBQ")]
        [DisplayName("Start Date")]
        [IsoXmlTag("StartDt")]
        public required DateFormat45Choice_ StartDate { get; init; } 
        
        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_j3y5JbQYEeeKRKrD60ELBQ")]
        [DisplayName("End Date")]
        [IsoXmlTag("EndDt")]
        public required DateFormat45Choice_ EndDate { get; init; } 
        
        
        #nullable disable
        
    }
}
