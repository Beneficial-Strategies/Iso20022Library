// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// Swiss Interbank Clearing (SIC) Code - identifies Swiss financial institutions domestically, on the Swiss national clearing system.
    /// </summary>
    [IsoId("_VwSCebNIEeejueAciesPMA")]
    [DisplayName("Swiss SIC Identification")]
    public partial record SwissSICIdentification : ClearingSystemMemberIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Swiss Interbank Clearing (SIC) Code. Identifies Swiss financial institutions domestically, on the Swiss national clearing system.
        /// </summary>
        [IsoXmlTag("CHSIC")]
        [IsoSimpleType(IsoSimpleType.SwissSICIdentifier)]
        public required IsoSwissSICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
