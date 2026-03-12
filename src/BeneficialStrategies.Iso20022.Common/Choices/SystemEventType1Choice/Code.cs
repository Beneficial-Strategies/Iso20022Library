// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemEventType1Choice
{
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_RD_Kktp-Ed-ak6NoX_4Aeg_553099190")]
    [DisplayName("Code")]
    public partial record Code : SystemEventType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of event related to a system&apos;s operation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemEventType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
