// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Disclosure1Choice
{
    /// <summary>
    /// Details of the account, account sub-levels and holdings.
    /// </summary>
    [IsoId("_WtmescANEembi_x1QDJfxw")]
    [DisplayName("Safekeeping Account And Holdings")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SafekeepingAccountAndHoldings : Disclosure1Choice_
    #else
    public partial class SafekeepingAccountAndHoldings : Disclosure1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SafekeepingAccountAndHoldings instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SafekeepingAccountAndHoldings( System.String reqSafekeepingAccount,PartyIdentification195Choice_ reqAccountServicer,FinancialInstrumentQuantity18Choice_ reqShareholdingBalanceOnOwnAccount,FinancialInstrumentQuantity18Choice_ reqShareholdingBalanceOnClientAccount,FinancialInstrumentQuantity18Choice_ reqTotalShareholdingBalance )
        {
            SafekeepingAccount = reqSafekeepingAccount;
            AccountServicer = reqAccountServicer;
            ShareholdingBalanceOnOwnAccount = reqShareholdingBalanceOnOwnAccount;
            ShareholdingBalanceOnClientAccount = reqShareholdingBalanceOnClientAccount;
            TotalShareholdingBalance = reqTotalShareholdingBalance;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained. Account held by the responding intermediary with its account servicer.
        /// </summary>
        [IsoId("_913X9DqoEemL_ewJY9QP1g")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text SafekeepingAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SafekeepingAccount { get; init; } 
        #else
        public System.String SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_F9KWnjqmEemL_ewJY9QP1g")]
        [DisplayName("Account Servicer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctSvcr")]
        #endif
        [IsoXmlTag("AcctSvcr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification195Choice_ AccountServicer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification195Choice_ AccountServicer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification195Choice_ AccountServicer { get; init; } 
        #else
        public PartyIdentification195Choice_ AccountServicer { get; set; } 
        #endif
        
        /// <summary>
        /// Number of shares held by the responding intermediary on its own account.
        /// </summary>
        [IsoId("_tuVJIDqnEemL_ewJY9QP1g")]
        [DisplayName("Shareholding Balance On Own Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrhldgBalOnOwnAcct")]
        #endif
        [IsoXmlTag("ShrhldgBalOnOwnAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; } 
        #else
        public FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Number of shares held by the responding intermediary on account of someone else.
        /// </summary>
        [IsoId("_61RxQDqnEemL_ewJY9QP1g")]
        [DisplayName("Shareholding Balance On Client Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrhldgBalOnClntAcct")]
        #endif
        [IsoXmlTag("ShrhldgBalOnClntAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; } 
        #else
        public FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Total number of shares held by the responding intermediary.
        /// </summary>
        [IsoId("_B-KfgDqoEemL_ewJY9QP1g")]
        [DisplayName("Total Shareholding Balance")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TtlShrhldgBal")]
        #endif
        [IsoXmlTag("TtlShrhldgBal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; } 
        #else
        public FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; set; } 
        #endif
        
        /// <summary>
        /// Shareholdings information at account sub level.
        /// </summary>
        [IsoId("_ZKpiUDqqEemL_ewJY9QP1g")]
        [DisplayName("Account Sub Level")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctSubLvl")]
        #endif
        [IsoXmlTag("AcctSubLvl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountSublevel21? AccountSubLevel { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountSublevel21? AccountSubLevel { get; init; } 
        #else
        public AccountSublevel21? AccountSubLevel { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
