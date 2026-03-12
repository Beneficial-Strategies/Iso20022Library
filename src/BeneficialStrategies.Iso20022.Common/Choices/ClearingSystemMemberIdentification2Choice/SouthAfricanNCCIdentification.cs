// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// South African National Clearing Code (NCC) - identifies South African financial institutions on the South African national clearing system. The code is assigned by the South African Bankers Services Company Ltd. (BankServ).
    /// </summary>
    [IsoId("_TDF7lNp-Ed-ak6NoX_4Aeg_1990860839")]
    [DisplayName("South African NCC Identification")]
    public partial record SouthAfricanNCCIdentification : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// South African National Clearing Code (NCC). Identifies South African financial institutions on the South African national clearing system. The code is assigned by the South African Bankers Services Company Ltd. (BankServ).
        /// </summary>
        [IsoXmlTag("ZANCC")]
        [IsoSimpleType(IsoSimpleType.SouthAfricanNCCIdentifier)]
        public required IsoSouthAfricanNCCIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
