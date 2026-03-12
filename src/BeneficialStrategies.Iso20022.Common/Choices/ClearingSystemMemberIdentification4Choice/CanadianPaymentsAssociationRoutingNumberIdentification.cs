// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// Canadian Payments Association Routing Number - identifies Canadian financial institutions on the Canadian national clearing system.
    /// </summary>
    [IsoId("_VwSCd7NIEeejueAciesPMA")]
    [DisplayName("Canadian Payments Association Routing Number Identification")]
    public partial record CanadianPaymentsAssociationRoutingNumberIdentification : ClearingSystemMemberIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Canadian Payments Association Routing Number. Identifies Canadian financial institutions on the Canadian national clearing system.
        /// </summary>
        [IsoXmlTag("CACPA")]
        [IsoSimpleType(IsoSimpleType.CanadianPaymentsARNIdentifier)]
        public required IsoCanadianPaymentsARNIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
