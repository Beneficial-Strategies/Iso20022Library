// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll1Choice
{
    /// <summary>
    /// Identification of all standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_790-0KMgEeCJ6YNENx4h-w_1737485731")]
    [DisplayName("All Standing Orders")]
    public partial record AllStandingOrders : StandingOrderOrAll1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
        /// </summary>
        [IsoId("_790-0qMgEeCJ6YNENx4h-w_-1404472770")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount24 Account { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_790-06MgEeCJ6YNENx4h-w_2086659832")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        
        
        #nullable disable
        
    }
}
