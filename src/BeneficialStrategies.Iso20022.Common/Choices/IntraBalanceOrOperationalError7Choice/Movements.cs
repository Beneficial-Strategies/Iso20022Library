// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError7Choice
{
    /// <summary>
    /// Identifies the transactions.
    /// </summary>
    [IsoId("_YDGlITneEem7JZMuWtwtsg")]
    [DisplayName("Movements")]
    public partial record Movements : IntraBalanceOrOperationalError7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account to or from which an entry is made.
        /// </summary>
        [IsoId("_YN1OeTneEem7JZMuWtwtsg")]
        [DisplayName("Cash Account")]
        [IsoXmlTag("CshAcct")]
        public CashAccount38? CashAccount { get; init; } 
        
        /// <summary>
        /// Party that owns the account.
        /// </summary>
        [IsoId("_YN1OdzneEem7JZMuWtwtsg")]
        [DisplayName("Cash Account Owner")]
        [IsoXmlTag("CshAcctOwnr")]
        public SystemPartyIdentification8? CashAccountOwner { get; init; } 
        
        /// <summary>
        /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_lqm_kTqBEemJ3KLLPeYl6g")]
        [DisplayName("Cash Account Servicer")]
        [IsoXmlTag("CshAcctSvcr")]
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        
        /// <summary>
        /// Status and status reason of the transaction.
        /// </summary>
        [IsoId("_YN1OezneEem7JZMuWtwtsg")]
        [DisplayName("Status And Reason")]
        [IsoXmlTag("StsAndRsn")]
        public IntraBalanceStatusAndReason2? StatusAndReason { get; init; } 
        
        /// <summary>
        /// Further details on the individual intrabalance movement transaction.
        /// </summary>
        [IsoId("_YN1OfTneEem7JZMuWtwtsg")]
        [DisplayName("Movement")]
        [IsoXmlTag("Mvmnt")]
        public ValueList<IntraBalanceMovement5> Movement { get; init; } = new ValueList<IntraBalanceMovement5>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _YN1OfTneEem7JZMuWtwtsg
        
        
        #nullable disable
        
    }
}
