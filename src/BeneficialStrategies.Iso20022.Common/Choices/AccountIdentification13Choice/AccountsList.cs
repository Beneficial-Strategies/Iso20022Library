// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification13Choice
{
    /// <summary>
    /// Selected safekeeping accounts list to which the corporate action event applies.
    /// </summary>
    [IsoId("_qVGz6-aPEd-q8fx_Zl_34A")]
    [DisplayName("Accounts List")]
    [IsoXmlTag("AcctsList")]
    public record AccountsList : AccountIdentification13Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_qVGz7-aPEd-q8fx_Zl_34A")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_qVGz8eaPEd-q8fx_Zl_34A")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification36Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_qVGz8-aPEd-q8fx_Zl_34A")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }
    }
}
