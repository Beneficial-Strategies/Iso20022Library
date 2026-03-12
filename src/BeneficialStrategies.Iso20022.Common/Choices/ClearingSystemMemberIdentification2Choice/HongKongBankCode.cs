// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Hong Kong Bank Code - identifies Hong Kong financial institutions on the Hong Kong local clearing system.
    /// </summary>
    [IsoId("_TDF7ldp-Ed-ak6NoX_4Aeg_1990860882")]
    [DisplayName("Hong Kong Bank Code")]
    public partial record HongKongBankCode : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Hong Kong Bank Code. Identifies Hong Kong financial institutions on the Hong Kong local clearing system.
        /// </summary>
        [IsoXmlTag("HKNCC")]
        [IsoSimpleType(IsoSimpleType.HongKongBankIdentifier)]
        public required IsoHongKongBankIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
