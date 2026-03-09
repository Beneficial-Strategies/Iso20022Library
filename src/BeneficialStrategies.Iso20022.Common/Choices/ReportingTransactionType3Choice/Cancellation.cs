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
namespace BeneficialStrategies.Iso20022.Choices.ReportingTransactionType3Choice
{
    /// <summary>
    /// Transaction is a cancellation transaction.
    /// </summary>
    [IsoId("_6eO9U5icEe2f7NHvXATP5g")]
    [DisplayName("Cancellation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Cancellation : ReportingTransactionType3Choice_
    #else
    public partial class Cancellation : ReportingTransactionType3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Cancellation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Cancellation( System.String reqTransactionIdentification,System.String reqExecutingParty,System.String reqSubmittingParty )
        {
            TransactionIdentification = reqTransactionIdentification;
            ExecutingParty = reqExecutingParty;
            SubmittingParty = reqSubmittingParty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the transaction.
        /// </summary>
        [IsoId("_CVjMkyrlEeWiy6-TnRWhpA")]
        [DisplayName("Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxId")]
        #endif
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text TransactionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TransactionIdentification { get; init; } 
        #else
        public System.String TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the entity executing the transaction. 
        /// Usage:
        /// For legal entities, use the legal entity identifier. For non-legal entities, this field shall be populated with an identifier as specified in the local regulation.
        /// </summary>
        [IsoId("_CVjMmSrlEeWiy6-TnRWhpA")]
        [DisplayName("Executing Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctgPty")]
        #endif
        [IsoXmlTag("ExctgPty")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoLEIIdentifier ExecutingParty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ExecutingParty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ExecutingParty { get; init; } 
        #else
        public System.String ExecutingParty { get; set; } 
        #endif
        
        /// <summary>
        /// Entity submitting the transaction report to the competent authority.
        /// </summary>
        [IsoId("_QrvSQFymEeWe9sWf-OA_kA")]
        [DisplayName("Submitting Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SubmitgPty")]
        #endif
        [IsoXmlTag("SubmitgPty")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoLEIIdentifier SubmittingParty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SubmittingParty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SubmittingParty { get; init; } 
        #else
        public System.String SubmittingParty { get; set; } 
        #endif
        
        /// <summary>
        /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
        /// </summary>
        [IsoId("_vgWC4DH8EeWRJePX1ORoaw")]
        [DisplayName("Technical Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechAttrbts")]
        #endif
        [IsoXmlTag("TechAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RecordTechnicalData2? TechnicalAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RecordTechnicalData2? TechnicalAttributes { get; init; } 
        #else
        public RecordTechnicalData2? TechnicalAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_WLYxoMpeEeW3lKrJLTgxRg")]
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
