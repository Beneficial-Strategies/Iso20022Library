// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument6Choice
{
    /// <summary>
    /// The part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_VKiwRdp-Ed-ak6NoX_4Aeg_1224511124")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public record AccountDetails : PaymentInstrument6Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_U9RwVNp-Ed-ak6NoX_4Aeg_-2850192")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification1? AccountIdentification { get; init; }

        /// <summary>
        /// Account type.
        /// </summary>
        [IsoId("_U9RwVdp-Ed-ak6NoX_4Aeg_791350549")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public CashAccountType1? Type { get; init; }
    }
}
