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
namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice
{
    /// <summary>
    /// Indicates contract that is to be reported as a new trade and also included in a separate position report on the same day.
    /// </summary>
    [IsoId("_zvSsecg3EeuGrNSsxk3B0A")]
    [DisplayName("Position Component")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PositionComponent : TradeReport22Choice_
    #else
    public partial class PositionComponent : TradeReport22Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PositionComponent instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PositionComponent( CounterpartyData88 reqCounterpartySpecificData,ModificationLevel1Code reqLevelType )
        {
            CounterpartySpecificData = reqCounterpartySpecificData;
            LevelType = reqLevelType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_AJ1aAcz4EeufhKfUxzsnrQ")]
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
        [IsoId("_AJ1aA8z4EeufhKfUxzsnrQ")]
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
        [IsoId("_AJ1aBcz4EeufhKfUxzsnrQ")]
        [DisplayName("Loan Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LnData")]
        #endif
        [IsoXmlTag("LnData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionLoanData32Choice_? LoanData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionLoanData32Choice_? LoanData { get; init; } 
        #else
        public TransactionLoanData32Choice_? LoanData { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the details of the collateral used in the transaction.
        /// </summary>
        [IsoId("_AJ1aB8z4EeufhKfUxzsnrQ")]
        [DisplayName("Collateral Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollData")]
        #endif
        [IsoXmlTag("CollData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralData35? CollateralData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralData35? CollateralData { get; init; } 
        #else
        public CollateralData35? CollateralData { get; set; } 
        #endif
        
        /// <summary>
        /// Information concerning the reported transaction level type.
        /// </summary>
        [IsoId("_AJ1aCcz4EeufhKfUxzsnrQ")]
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
        [IsoId("_AJ1aC8z4EeufhKfUxzsnrQ")]
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
