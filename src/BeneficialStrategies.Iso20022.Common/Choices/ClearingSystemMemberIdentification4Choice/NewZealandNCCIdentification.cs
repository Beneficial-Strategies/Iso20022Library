// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// New Zealand Bank/Branch Code - identifies New Zealand institutions on the New Zealand national clearing system. The code is assigned by the New Zealand Bankers&apos; Association (NZBA).
    /// </summary>
    [IsoId("_VwSCY7NIEeejueAciesPMA")]
    [DisplayName("New Zealand NCC Identification")]
    public partial record NewZealandNCCIdentification : ClearingSystemMemberIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// New Zealand Bank/Branch Code. Identifies New Zealand institutions on the New Zealand national clearing system. The code is assigned by the New Zealand Bankers&apos; Association (NZBA).
        /// </summary>
        [IsoXmlTag("NZNCC")]
        [IsoSimpleType(IsoSimpleType.NewZealandNCCIdentifier)]
        public required IsoNewZealandNCCIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
