// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CreditorEnrolmentAmendmentReason1Choice
{
    /// <summary>
    /// Reason, as published in an external reason code list.
    /// </summary>
    [IsoId("_yRMkL_DBEemsS_0xy2XRug")]
    [DisplayName("Code")]
    public partial record Code : CreditorEnrolmentAmendmentReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCreditorEnrolmentAmendmentReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
