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
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError8Choice
{
    /// <summary>
    /// Requested information on the account.
    /// </summary>
    [IsoId("_edTg0dcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StandingOrder : StandingOrderOrError8Choice_
    #else
    public partial class StandingOrder : StandingOrderOrError8Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StandingOrder instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StandingOrder( Amount2Choice_ reqAmount,CreditDebitCode reqCreditDebitIndicator )
        {
            Amount = reqAmount;
            CreditDebitIndicator = reqCreditDebitIndicator;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
        /// </summary>
        [IsoId("_ef46wdcZEeqRFcf2R4bPBw")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Amount2Choice_ Amount { get; init; } 
        #else
        public Amount2Choice_ Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if the account is debited or credited by the standing order.
        /// </summary>
        [IsoId("_ef46w9cZEeqRFcf2R4bPBw")]
        [DisplayName("Credit Debit Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtDbtInd")]
        #endif
        [IsoXmlTag("CdtDbtInd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CreditDebitCode CreditDebitIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CreditDebitCode CreditDebitIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDebitCode CreditDebitIndicator { get; init; } 
        #else
        public CreditDebitCode CreditDebitIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_ef46xdcZEeqRFcf2R4bPBw")]
        [DisplayName("Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ccy")]
        #endif
        [IsoXmlTag("Ccy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyCode? Currency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? Currency { get; init; } 
        #else
        public string? Currency { get; set; } 
        #endif
        
        /// <summary>
        /// Type of the standing order.
        /// </summary>
        [IsoId("_ef46x9cZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public StandingOrderType1Choice_? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StandingOrderType1Choice_? Type { get; init; } 
        #else
        public StandingOrderType1Choice_? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
        /// </summary>
        [IsoId("_ef46ydcZEeqRFcf2R4bPBw")]
        [DisplayName("Associated Pool Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AssoctdPoolAcct")]
        #endif
        [IsoXmlTag("AssoctdPoolAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; } 
        #else
        public AccountIdentification4Choice_? AssociatedPoolAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_ef46y9cZEeqRFcf2R4bPBw")]
        [DisplayName("Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ref")]
        #endif
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Reference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Reference { get; init; } 
        #else
        public System.String? Reference { get; set; } 
        #endif
        
        /// <summary>
        /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
        /// </summary>
        [IsoId("_ef46zdcZEeqRFcf2R4bPBw")]
        [DisplayName("Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Frqcy")]
        #endif
        [IsoXmlTag("Frqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Frequency2Code? Frequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency2Code? Frequency { get; init; } 
        #else
        public Frequency2Code? Frequency { get; set; } 
        #endif
        
        /// <summary>
        /// Dates during which the standing order is in effect.
        /// </summary>
        [IsoId("_ef46z9cZEeqRFcf2R4bPBw")]
        [DisplayName("Validity Period")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldtyPrd")]
        #endif
        [IsoXmlTag("VldtyPrd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DatePeriod3? ValidityPeriod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DatePeriod3? ValidityPeriod { get; init; } 
        #else
        public DatePeriod3? ValidityPeriod { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if the account is debited or credited by the standing order.
        /// </summary>
        [IsoId("_ef460dcZEeqRFcf2R4bPBw")]
        [DisplayName("System Member")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SysMmb")]
        #endif
        [IsoXmlTag("SysMmb")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? SystemMember { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? SystemMember { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? SystemMember { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_ef4609cZEeqRFcf2R4bPBw")]
        [DisplayName("Responsible Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RspnsblPty")]
        #endif
        [IsoXmlTag("RspnsblPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
        /// </summary>
        [IsoId("_ef461dcZEeqRFcf2R4bPBw")]
        [DisplayName("Link Set Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LkSetId")]
        #endif
        [IsoXmlTag("LkSetId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? LinkSetIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LinkSetIdentification { get; init; } 
        #else
        public System.String? LinkSetIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
        /// </summary>
        [IsoId("_ef4619cZEeqRFcf2R4bPBw")]
        [DisplayName("Link Set Order Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LkSetOrdrId")]
        #endif
        [IsoXmlTag("LkSetOrdrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? LinkSetOrderIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LinkSetOrderIdentification { get; init; } 
        #else
        public System.String? LinkSetOrderIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
        /// </summary>
        [IsoId("_ef462dcZEeqRFcf2R4bPBw")]
        [DisplayName("Link Set Order Sequence")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LkSetOrdrSeq")]
        #endif
        [IsoXmlTag("LkSetOrdrSeq")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? LinkSetOrderSequence { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? LinkSetOrderSequence { get; init; } 
        #else
        public System.UInt64? LinkSetOrderSequence { get; set; } 
        #endif
        
        /// <summary>
        /// Defines whether the standing order is executed through a time-based or an event-based trigger.
        /// </summary>
        [IsoId("_ef4629cZEeqRFcf2R4bPBw")]
        [DisplayName("Execution Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctnTp")]
        #endif
        [IsoXmlTag("ExctnTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExecutionType1Choice_? ExecutionType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExecutionType1Choice_? ExecutionType { get; init; } 
        #else
        public ExecutionType1Choice_? ExecutionType { get; set; } 
        #endif
        
        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_ef463dcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Cash account credited from a standing order mechanism.
        /// </summary>
        [IsoId("_ef4639cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAcct")]
        #endif
        [IsoXmlTag("CdtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount40? CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40? CreditorAccount { get; init; } 
        #else
        public CashAccount40? CreditorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_ef464dcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dbtr")]
        #endif
        [IsoXmlTag("Dbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? Debtor { get; set; } 
        #endif
        
        /// <summary>
        /// Cash account debited from a standing order mechanism.
        /// </summary>
        [IsoId("_ef4649cZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAcct")]
        #endif
        [IsoXmlTag("DbtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount40? DebtorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40? DebtorAccount { get; init; } 
        #else
        public CashAccount40? DebtorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Overall amount of &quot;not yet executed&quot; predefined liquidity transfer orders or &quot;defined&quot; by a system participant in its sphere of responsibility within the system.
        /// </summary>
        [IsoId("_ef465dcZEeqRFcf2R4bPBw")]
        [DisplayName("Totals Per Standing Order")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TtlsPerStgOrdr")]
        #endif
        [IsoXmlTag("TtlsPerStgOrdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; init; } 
        #else
        public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the liquidity transfer standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
        /// </summary>
        [IsoId("_ef4659cZEeqRFcf2R4bPBw")]
        [DisplayName("Zero Sweep Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ZeroSweepInd")]
        #endif
        [IsoXmlTag("ZeroSweepInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ZeroSweepIndicator { get; init; } 
        #else
        public System.String? ZeroSweepIndicator { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
