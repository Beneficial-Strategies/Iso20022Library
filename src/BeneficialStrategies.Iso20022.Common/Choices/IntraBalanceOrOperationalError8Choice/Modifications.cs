// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError8Choice
{
    /// <summary>
    /// Further details of the intrabalance modification transactions.
    /// </summary>
    [IsoId("_Z496kTneEem7JZMuWtwtsg")]
    [DisplayName("Modifications")]
    public partial record Modifications : IntraBalanceOrOperationalError8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account to or from which a cash entry is made.
        /// </summary>
        [IsoId("_aD2U6TneEem7JZMuWtwtsg")]
        [DisplayName("Cash Account")]
        [IsoXmlTag("CshAcct")]
        public CashAccount38? CashAccount { get; init; } 
        
        /// <summary>
        /// Party that owns the account.
        /// </summary>
        [IsoId("_aD2U5zneEem7JZMuWtwtsg")]
        [DisplayName("Cash Account Owner")]
        [IsoXmlTag("CshAcctOwnr")]
        public SystemPartyIdentification8? CashAccountOwner { get; init; } 
        
        /// <summary>
        /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_ik5TMTp-EemwKdP955WBJQ")]
        [DisplayName("Cash Account Servicer")]
        [IsoXmlTag("CshAcctSvcr")]
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        
        /// <summary>
        /// Status and status reason of the transaction.
        /// </summary>
        [IsoId("_aD2U6zneEem7JZMuWtwtsg")]
        [DisplayName("Processing Status")]
        [IsoXmlTag("PrcgSts")]
        public ProcessingStatus71Choice_? ProcessingStatus { get; init; } 
        
        /// <summary>
        /// Further details of the individual intrabalance modification transaction.
        /// </summary>
        [IsoId("_aD2U7TneEem7JZMuWtwtsg")]
        [DisplayName("Modification")]
        [IsoXmlTag("Mod")]
        public ValueList<IntraBalanceModification6> Modification { get; init; } = [];
        // ID for the above is _aD2U7TneEem7JZMuWtwtsg
        
        
        #nullable disable
        
    }
}
