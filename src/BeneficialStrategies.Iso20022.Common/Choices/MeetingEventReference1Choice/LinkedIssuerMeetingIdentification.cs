// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MeetingEventReference1Choice
{
    /// <summary>
    /// Official and unique reference assigned by the official central body/ entity within each market at the beginning of a meeting event.
    /// </summary>
    [IsoId("__b3CG67rEemG7MmivSuE5g")]
    [DisplayName("Linked Issuer Meeting Identification")]
    public partial record LinkedIssuerMeetingIdentification : MeetingEventReference1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("LkdIssrMtgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
