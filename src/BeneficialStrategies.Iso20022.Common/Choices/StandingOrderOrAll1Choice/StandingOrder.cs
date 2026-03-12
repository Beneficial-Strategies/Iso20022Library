// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll1Choice
{
    /// <summary>
    /// Identification of single standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_79r04aMgEeCJ6YNENx4h-w_-893332304")]
    [DisplayName("Standing Order")]
    public partial record StandingOrder : StandingOrderOrAll1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_7-RqwaMgEeCJ6YNENx4h-w_-159770283")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; } 
        
        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
        /// </summary>
        [IsoId("_7-RqwqMgEeCJ6YNENx4h-w_-1549552003")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount24 Account { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_7-Rqw6MgEeCJ6YNENx4h-w_1595290372")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        
        
        #nullable disable
        
    }
}
