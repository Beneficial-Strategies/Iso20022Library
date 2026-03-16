// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument20Choice
{
    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_weKLIzbsEead9bDRE_1DAQ")]
    [DisplayName("Cash Account Details")]
    public record CashAccountDetails : PaymentInstrument20Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_5DKXFThiEeamLZQeccJa7w")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? AccountIdentification { get; init; }

        /// <summary>
        /// Account type.
        /// </summary>
        [IsoId("_5DKXFzhiEeamLZQeccJa7w")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public InvestmentAccountType1Choice_? Type { get; init; }
    }
}
