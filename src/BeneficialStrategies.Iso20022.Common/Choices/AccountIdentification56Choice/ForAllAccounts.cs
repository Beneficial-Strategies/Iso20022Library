// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification56Choice
{
    /// <summary>
    /// All safekeeping accounts that own an underlying financial instrument.
    /// </summary>
    [IsoId("_Q6fvUzgDEe23pOhj-2WbKw")]
    [DisplayName("For All Accounts")]
    public record ForAllAccounts : AccountIdentification56Choice_
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
