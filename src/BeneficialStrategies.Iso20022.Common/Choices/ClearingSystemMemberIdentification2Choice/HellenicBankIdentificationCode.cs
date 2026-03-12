// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Hellenic Bank Identification Code - identifies Hellenic financial institutions on the Hellenic national clearing system.
    /// </summary>
    [IsoId("_TDPFg9p-Ed-ak6NoX_4Aeg_-1906990554")]
    [DisplayName("Hellenic Bank Identification Code")]
    public partial record HellenicBankIdentificationCode : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Hellenic Bank Identification Code Identifier. Identifies Greek financial institutions on the Greek national clearing system.
        /// </summary>
        [IsoXmlTag("GRHEBIC")]
        [IsoSimpleType(IsoSimpleType.HellenicBankIdentificationCodeIdentifier)]
        public required IsoHellenicBankIdentificationCodeIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
