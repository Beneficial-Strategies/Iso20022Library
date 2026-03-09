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
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData21Choice
{
    /// <summary>
    /// Details of the buy sell back transaction.
    /// </summary>
    [IsoId("_4Eg3E__qEemm3skPVSMJQg")]
    [DisplayName("Buy Sell Back")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BuySellBack : TransactionLoanData21Choice_
    #else
    public partial class BuySellBack : TransactionLoanData21Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BuySellBack instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BuySellBack( System.DateOnly reqMaturityDate,System.String reqUniqueTradeIdentifier,System.DateOnly reqEventDate,Cleared10Choice_ reqClearingStatus,System.String reqTradingVenue,System.DateTime reqExecutionDateTime,System.DateOnly reqValueDate )
        {
            MaturityDate = reqMaturityDate;
            UniqueTradeIdentifier = reqUniqueTradeIdentifier;
            EventDate = reqEventDate;
            ClearingStatus = reqClearingStatus;
            TradingVenue = reqTradingVenue;
            ExecutionDateTime = reqExecutionDateTime;
            ValueDate = reqValueDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indication of the cash values to be settled as of the start and maturity date of the transaction.
        /// </summary>
        [IsoId("_CQancbOZEemDE9K-I5TT8Q")]
        [DisplayName("Principal Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrncplAmt")]
        #endif
        [IsoXmlTag("PrncplAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PrincipalAmount2? PrincipalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PrincipalAmount2? PrincipalAmount { get; init; } 
        #else
        public PrincipalAmount2? PrincipalAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
        /// </summary>
        [IsoId("_CQanc7OZEemDE9K-I5TT8Q")]
        [DisplayName("Maturity Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MtrtyDt")]
        #endif
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate MaturityDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly MaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly MaturityDate { get; init; } 
        #else
        public System.DateOnly MaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_CQandbOZEemDE9K-I5TT8Q")]
        [DisplayName("Unique Trade Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTradIdr")]
        #endif
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String UniqueTradeIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String UniqueTradeIdentifier { get; init; } 
        #else
        public System.String UniqueTradeIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
        /// </summary>
        [IsoId("_CQand7OZEemDE9K-I5TT8Q")]
        [DisplayName("Event Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDt")]
        #endif
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly EventDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDate { get; init; } 
        #else
        public System.DateOnly EventDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_CQanebOZEemDE9K-I5TT8Q")]
        [DisplayName("Clearing Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSts")]
        #endif
        [IsoXmlTag("ClrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Cleared10Choice_ ClearingStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Cleared10Choice_ ClearingStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Cleared10Choice_ ClearingStatus { get; init; } 
        #else
        public Cleared10Choice_ ClearingStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Venue of execution shall be identified by a unique code for this venue.
        /// </summary>
        [IsoId("_CQane7OZEemDE9K-I5TT8Q")]
        [DisplayName("Trading Venue")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradgVn")]
        #endif
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMICIdentifier TradingVenue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TradingVenue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TradingVenue { get; init; } 
        #else
        public System.String TradingVenue { get; set; } 
        #endif
        
        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_CQanfbOZEemDE9K-I5TT8Q")]
        [DisplayName("Master Agreement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrAgrmt")]
        #endif
        [IsoXmlTag("MstrAgrmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MasterAgreement6? MasterAgreement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MasterAgreement6? MasterAgreement { get; init; } 
        #else
        public MasterAgreement6? MasterAgreement { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_CQanf7OZEemDE9K-I5TT8Q")]
        [DisplayName("Execution Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctnDtTm")]
        #endif
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ExecutionDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime ExecutionDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ExecutionDateTime { get; init; } 
        #else
        public System.DateTime ExecutionDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_CQangbOZEemDE9K-I5TT8Q")]
        [DisplayName("Value Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ValDt")]
        #endif
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ValueDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ValueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ValueDate { get; init; } 
        #else
        public System.DateOnly ValueDate { get; set; } 
        #endif
        
        /// <summary>
        /// Termination date in the case of a full early termination of the reported transaction.
        /// </summary>
        [IsoId("_CQang7OZEemDE9K-I5TT8Q")]
        [DisplayName("Termination Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TermntnDt")]
        #endif
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? TerminationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? TerminationDate { get; init; } 
        #else
        public System.DateOnly? TerminationDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
        /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
        /// </summary>
        [IsoId("_CQanhbOZEemDE9K-I5TT8Q")]
        [DisplayName("General Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="GnlColl")]
        #endif
        [IsoXmlTag("GnlColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SpecialCollateral1Code? GeneralCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SpecialCollateral1Code? GeneralCollateral { get; init; } 
        #else
        public SpecialCollateral1Code? GeneralCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
        /// </summary>
        [IsoId("_CQanh7OZEemDE9K-I5TT8Q")]
        [DisplayName("Unit Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitPric")]
        #endif
        [IsoXmlTag("UnitPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
        #else
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
