// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Disclosure2Choice
{
    /// <summary>
    /// Details of the account, account sub-levels and holdings.
    /// </summary>
    [IsoId("_MM9hY_NyEeqRfth943bvEA")]
    [DisplayName("Safekeeping Account And Holdings")]
    public partial record SafekeepingAccountAndHoldings : Disclosure2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained. Account held by the responding intermediary with its account servicer.
        /// </summary>
        [IsoId("_Mhe_4fNyEeqRfth943bvEA")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; } 
        
        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_Mhe_6fNyEeqRfth943bvEA")]
        [DisplayName("Account Servicer")]
        [IsoXmlTag("AcctSvcr")]
        public required PartyIdentification195Choice_ AccountServicer { get; init; } 
        
        /// <summary>
        /// Number of shares held by the responding intermediary on its own account.
        /// </summary>
        [IsoId("_Mhe_6_NyEeqRfth943bvEA")]
        [DisplayName("Shareholding Balance On Own Account")]
        [IsoXmlTag("ShrhldgBalOnOwnAcct")]
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; } 
        
        /// <summary>
        /// Number of shares held by the responding intermediary on account of someone else.
        /// </summary>
        [IsoId("_Mhe_7fNyEeqRfth943bvEA")]
        [DisplayName("Shareholding Balance On Client Account")]
        [IsoXmlTag("ShrhldgBalOnClntAcct")]
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; } 
        
        /// <summary>
        /// Total number of shares held by the responding intermediary.
        /// </summary>
        [IsoId("_Mhe_7_NyEeqRfth943bvEA")]
        [DisplayName("Total Shareholding Balance")]
        [IsoXmlTag("TtlShrhldgBal")]
        public required FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; } 
        
        /// <summary>
        /// Shareholdings information at account sub level.
        /// </summary>
        [IsoId("_Mhe_8fNyEeqRfth943bvEA")]
        [DisplayName("Account Sub Level")]
        [IsoXmlTag("AcctSubLvl")]
        public AccountSubLevel22? AccountSubLevel { get; init; } 
        
        
        #nullable disable
        
    }
}
