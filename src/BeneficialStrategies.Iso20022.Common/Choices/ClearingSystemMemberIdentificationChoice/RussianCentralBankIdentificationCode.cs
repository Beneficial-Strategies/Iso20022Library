// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Russian Central Bank Identification Code - identifies Russian financial institutions on the Russian national clearing system.
    /// </summary>
    [IsoId("_TDY2htp-Ed-ak6NoX_4Aeg_-896562590")]
    [DisplayName("Russian Central Bank Identification Code")]
    public partial record RussianCentralBankIdentificationCode : ClearingSystemMemberIdentificationChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Russian Central Bank Identification Code. Identifies Russian financial institutions on the Russian national clearing system.
        /// </summary>
        [IsoXmlTag("RUCB")]
        [IsoSimpleType(IsoSimpleType.RussianCentralBankIdentificationCodeIdentifier)]
        public required IsoRussianCentralBankIdentificationCodeIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
