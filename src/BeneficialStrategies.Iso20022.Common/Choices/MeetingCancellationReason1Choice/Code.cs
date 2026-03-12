// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MeetingCancellationReason1Choice
{
    /// <summary>
    /// Specifies the reason for cancelling a meeting in coded form.
    /// </summary>
    [IsoId("_RCWL0tp-Ed-ak6NoX_4Aeg_-1788860770")]
    [DisplayName("Code")]
    public partial record Code : MeetingCancellationReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for cancelling a meeting.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MeetingCancellationReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
