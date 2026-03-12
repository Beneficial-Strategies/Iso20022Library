// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestPaymentSchedule1Choice
{
    /// <summary>
    /// Specifies an expected date and a due date for the interest payment.
    /// </summary>
    [IsoId("_u7i5ROFWEeSvv6t4Ka7B7A")]
    [DisplayName("Date Range")]
    public partial record DateRange : InterestPaymentSchedule1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the interest payment schedule.
        /// </summary>
        [IsoId("_L71BfdOJEeSQ_-lmj1tzfw")]
        [DisplayName("Interest Schedule Identification")]
        [IsoXmlTag("IntrstSchdlId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? InterestScheduleIdentification { get; init; } 
        
        /// <summary>
        /// Expected interest payment date.
        /// </summary>
        [IsoId("_L71Be9OJEeSQ_-lmj1tzfw")]
        [DisplayName("Expected Date")]
        [IsoXmlTag("XpctdDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ExpectedDate { get; init; } 
        
        /// <summary>
        /// Latest date whereby the interest must be paid.
        /// </summary>
        [IsoId("_L71BfNOJEeSQ_-lmj1tzfw")]
        [DisplayName("Due Date")]
        [IsoXmlTag("DueDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DueDate { get; init; } 
        
        
        #nullable disable
        
    }
}
