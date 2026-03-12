// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentSchedule1Choice
{
    /// <summary>
    /// Specifies an expected date and a due date for the payment.
    /// </summary>
    [IsoId("_BhnbcdOAEeSQ_-lmj1tzfw")]
    [DisplayName("Date Range")]
    public partial record DateRange : PaymentSchedule1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the payment schedule.
        /// </summary>
        [IsoId("_uqWlEdOAEeSQ_-lmj1tzfw")]
        [DisplayName("Payment Schedule Identification")]
        [IsoXmlTag("PmtSchdlId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? PaymentScheduleIdentification { get; init; } 
        
        /// <summary>
        /// Expected payment date.
        /// </summary>
        [IsoId("_LABPkdOAEeSQ_-lmj1tzfw")]
        [DisplayName("Expected Date")]
        [IsoXmlTag("XpctdDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ExpectedDate { get; init; } 
        
        /// <summary>
        /// Latest date whereby the amount must be paid.
        /// </summary>
        [IsoId("_LABPk9OAEeSQ_-lmj1tzfw")]
        [DisplayName("Due Date")]
        [IsoXmlTag("DueDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DueDate { get; init; } 
        
        
        #nullable disable
        
    }
}
