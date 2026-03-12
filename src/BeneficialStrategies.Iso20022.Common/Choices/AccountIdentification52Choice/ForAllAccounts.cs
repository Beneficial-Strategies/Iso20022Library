// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification52Choice
{
    /// <summary>
    /// All safekeeping accounts that own an underlying financial instrument.
    /// </summary>
    [IsoId("_ps_Rrzi7Eeydid5dcNPKvg")]
    [DisplayName("For All Accounts")]
    public partial record ForAllAccounts : AccountIdentification52Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
        /// </summary>
        [IsoId("_QSgqVNp-Ed-ak6NoX_4Aeg_-758816150")]
        [DisplayName("Identification Code")]
        [IsoXmlTag("IdCd")]
        public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
        
        
        #nullable disable
        
    }
}
