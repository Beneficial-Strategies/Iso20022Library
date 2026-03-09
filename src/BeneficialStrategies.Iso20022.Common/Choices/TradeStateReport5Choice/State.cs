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
namespace BeneficialStrategies.Iso20022.Choices.TradeStateReport5Choice
{
    /// <summary>
    /// Information related to trade state reporting.
    /// </summary>
    [IsoId("_x-2JI8K-EeuCIrYISEfoUg")]
    [DisplayName("State")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record State : TradeStateReport5Choice_
    #else
    public partial class State : TradeStateReport5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a State instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public State( CounterpartyData88 reqCounterpartySpecificData,ContractModification3 reqContractModification )
        {
            CounterpartySpecificData = reqCounterpartySpecificData;
            ContractModification = reqContractModification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_yAM0AcK-EeuCIrYISEfoUg")]
        [DisplayName("Technical Record Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechRcrdId")]
        #endif
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TechnicalRecordIdentification { get; init; } 
        #else
        public System.String? TechnicalRecordIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_yAM0A8K-EeuCIrYISEfoUg")]
        [DisplayName("Counterparty Specific Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtySpcfcData")]
        #endif
        [IsoXmlTag("CtrPtySpcfcData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyData88 CounterpartySpecificData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CounterpartyData88 CounterpartySpecificData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyData88 CounterpartySpecificData { get; init; } 
        #else
        public CounterpartyData88 CounterpartySpecificData { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_yAM0BcK-EeuCIrYISEfoUg")]
        [DisplayName("Loan Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LnData")]
        #endif
        [IsoXmlTag("LnData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionLoanData31Choice_? LoanData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionLoanData31Choice_? LoanData { get; init; } 
        #else
        public TransactionLoanData31Choice_? LoanData { get; set; } 
        #endif
        
        /// <summary>
        /// Set of information on collateral used in the transaction.
        /// </summary>
        [IsoId("_yAM0B8K-EeuCIrYISEfoUg")]
        [DisplayName("Collateral Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollData")]
        #endif
        [IsoXmlTag("CollData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionCollateralData18Choice_? CollateralData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionCollateralData18Choice_? CollateralData { get; init; } 
        #else
        public TransactionCollateralData18Choice_? CollateralData { get; set; } 
        #endif
        
        /// <summary>
        /// List of possible values for TRs reconciliation purposes.
        /// </summary>
        [IsoId("_yAM0CcK-EeuCIrYISEfoUg")]
        [DisplayName("Reconciliation Flag")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcncltnFlg")]
        #endif
        [IsoXmlTag("RcncltnFlg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReconciliationFlag2? ReconciliationFlag { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReconciliationFlag2? ReconciliationFlag { get; init; } 
        #else
        public ReconciliationFlag2? ReconciliationFlag { get; set; } 
        #endif
        
        /// <summary>
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_yAM0C8K-EeuCIrYISEfoUg")]
        [DisplayName("Contract Modification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctMod")]
        #endif
        [IsoXmlTag("CtrctMod")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ContractModification3 ContractModification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ContractModification3 ContractModification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractModification3 ContractModification { get; init; } 
        #else
        public ContractModification3 ContractModification { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_yAM0DcK-EeuCIrYISEfoUg")]
        [DisplayName("Supplementary Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryData")]
        #endif
        [IsoXmlTag("SplmtryData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
