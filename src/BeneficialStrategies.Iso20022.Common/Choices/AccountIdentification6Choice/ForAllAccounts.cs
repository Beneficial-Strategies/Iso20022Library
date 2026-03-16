// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification6Choice
{
    /// <summary>
    /// All safekeeping accounts that own underlying financial instrument.
    /// </summary>
    [IsoId("_QSgqVtp-Ed-ak6NoX_4Aeg_-1574969341")]
    [DisplayName("For All Accounts")]
    public record ForAllAccounts : AccountIdentification6Choice_
    {
        /// <summary>
        /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
        /// </summary>
        [IsoId("_QSgqVNp-Ed-ak6NoX_4Aeg_-758816150")]
        [DisplayName("Identification Code")]
        [IsoXmlTag("IdCd")]
        public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; }
    }
}
