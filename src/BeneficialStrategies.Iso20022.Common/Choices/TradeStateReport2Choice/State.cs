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
namespace BeneficialStrategies.Iso20022.Choices.TradeStateReport2Choice
{
    /// <summary>
    /// Information related to trade state reporting.
    /// </summary>
    [IsoId("_fCvncwAFEeqefbt-QjTNnA")]
    [DisplayName("State")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record State : TradeStateReport2Choice_
    #else
    public partial class State : TradeStateReport2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a State instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public State( CounterpartyData76 reqCounterpartyData,ContractModification2 reqContractModification )
        {
            CounterpartyData = reqCounterpartyData;
            ContractModification = reqContractModification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_fH7CYQAFEeqefbt-QjTNnA")]
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
        [IsoId("_fH7CYwAFEeqefbt-QjTNnA")]
        [DisplayName("Counterparty Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyData")]
        #endif
        [IsoXmlTag("CtrPtyData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyData76 CounterpartyData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CounterpartyData76 CounterpartyData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyData76 CounterpartyData { get; init; } 
        #else
        public CounterpartyData76 CounterpartyData { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_fH7CZQAFEeqefbt-QjTNnA")]
        [DisplayName("Loan Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LnData")]
        #endif
        [IsoXmlTag("LnData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionLoanData20Choice_? LoanData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionLoanData20Choice_? LoanData { get; init; } 
        #else
        public TransactionLoanData20Choice_? LoanData { get; set; } 
        #endif
        
        /// <summary>
        /// Information on collateral used in the transaction.
        /// </summary>
        [IsoId("_fH7CZwAFEeqefbt-QjTNnA")]
        [DisplayName("Collateral Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollData")]
        #endif
        [IsoXmlTag("CollData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionCollateralData15Choice_? CollateralData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionCollateralData15Choice_? CollateralData { get; init; } 
        #else
        public TransactionCollateralData15Choice_? CollateralData { get; set; } 
        #endif
        
        /// <summary>
        /// List of possible values for TRs reconciliation purposes.
        /// </summary>
        [IsoId("_fH7CaQAFEeqefbt-QjTNnA")]
        [DisplayName("Reconciliation Flag")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcncltnFlg")]
        #endif
        [IsoXmlTag("RcncltnFlg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReconciliationFlag1? ReconciliationFlag { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReconciliationFlag1? ReconciliationFlag { get; init; } 
        #else
        public ReconciliationFlag1? ReconciliationFlag { get; set; } 
        #endif
        
        /// <summary>
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_fH7CawAFEeqefbt-QjTNnA")]
        [DisplayName("Contract Modification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctMod")]
        #endif
        [IsoXmlTag("CtrctMod")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ContractModification2 ContractModification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ContractModification2 ContractModification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractModification2 ContractModification { get; init; } 
        #else
        public ContractModification2 ContractModification { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_fH7CbQAFEeqefbt-QjTNnA")]
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
