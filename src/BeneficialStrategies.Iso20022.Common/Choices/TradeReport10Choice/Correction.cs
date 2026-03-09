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
namespace BeneficialStrategies.Iso20022.Choices.TradeReport10Choice
{
    /// <summary>
    /// Indicates a modification to the terms or details of a previously reported position or correction the erroneous data fields of a previously submitted position.
    /// </summary>
    [IsoId("_38nfXf_qEemm3skPVSMJQg")]
    [DisplayName("Correction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Correction : TradeReport10Choice_
    #else
    public partial class Correction : TradeReport10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Correction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Correction( CounterpartyData76 reqCounterpartyData,ModificationLevel1Code reqLevelType )
        {
            CounterpartyData = reqCounterpartyData;
            LevelType = reqLevelType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_0sDrgQAAEeqefbt-QjTNnA")]
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
        [IsoId("_0sDrgwAAEeqefbt-QjTNnA")]
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
        [IsoId("_0sDrhQAAEeqefbt-QjTNnA")]
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
        [IsoId("_0sDrhwAAEeqefbt-QjTNnA")]
        [DisplayName("Collateral Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollData")]
        #endif
        [IsoXmlTag("CollData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionCollateralData14Choice_? CollateralData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionCollateralData14Choice_? CollateralData { get; init; } 
        #else
        public TransactionCollateralData14Choice_? CollateralData { get; set; } 
        #endif
        
        /// <summary>
        /// Information concerning the reported transaction level type.
        /// </summary>
        [IsoId("_0sDriQAAEeqefbt-QjTNnA")]
        [DisplayName("Level Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LvlTp")]
        #endif
        [IsoXmlTag("LvlTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ModificationLevel1Code LevelType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ModificationLevel1Code LevelType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ModificationLevel1Code LevelType { get; init; } 
        #else
        public ModificationLevel1Code LevelType { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_0sDriwAAEeqefbt-QjTNnA")]
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
