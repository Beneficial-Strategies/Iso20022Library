// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification1Choice
{
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_ko4LsO5NEeCisYr99QEiWA_1625094911")]
    [DisplayName("Party Identification")]
    public partial record PartyIdentification : SystemPartyModification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Starting date from which the identification is valid.
        /// </summary>
        [IsoId("_knPM8O5NEeCisYr99QEiWA_2146240777")]
        [DisplayName("Valid From")]
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ValidFrom { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous way to identify a system party.
        /// </summary>
        [IsoId("_knPM8e5NEeCisYr99QEiWA_-852146574")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public IsoBICFIIdentifier? Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
