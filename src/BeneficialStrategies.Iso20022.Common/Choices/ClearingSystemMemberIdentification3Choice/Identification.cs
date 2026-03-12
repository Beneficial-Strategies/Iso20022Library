// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification3Choice
{
    /// <summary>
    /// Identification for a clearing system member, identified in the list of clearing system member identifications published externally.
    /// </summary>
    [IsoId("_TMehGtp-Ed-ak6NoX_4Aeg_-1564562062")]
    [DisplayName("Identification")]
    public partial record Identification : ClearingSystemMemberIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external clearing system member code in the format of character string with a maximum length of 35 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Id")]
        public required ExternalClearingSystemMemberCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
