// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// German Bankleitzahl - identifies German financial institutions on the German national clearing systems.
    /// </summary>
    [IsoId("_VwSCe7NIEeejueAciesPMA")]
    [DisplayName("German Bankleitzahl Identification")]
    public partial record GermanBankleitzahlIdentification : ClearingSystemMemberIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// German Bankleitzahl. Identifies German financial institutions on the German national clearing systems.
        /// </summary>
        [IsoXmlTag("DEBLZ")]
        [IsoSimpleType(IsoSimpleType.GermanBankleitzahlIdentifier)]
        public required IsoGermanBankleitzahlIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
