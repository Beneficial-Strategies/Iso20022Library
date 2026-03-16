// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll3Choice
{
    /// <summary>
    /// Identification of single standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_ex1mYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order")]
    public record StandingOrder : StandingOrderOrAll3Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_bTVfMdcZEeqRFcf2R4bPBw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; }

        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
        /// </summary>
        [IsoId("_bTVfM9cZEeqRFcf2R4bPBw")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount40 Account { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_bTVfNdcZEeqRFcf2R4bPBw")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }
    }
}
