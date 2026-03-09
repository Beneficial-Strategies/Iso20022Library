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
namespace BeneficialStrategies.Iso20022.Choices.ReportingTransactionType2Choice
{
    /// <summary>
    /// Transaction is a newly reported transaction.
    /// </summary>
    [IsoId("_XM1TEZ26Eeuwmdq0KtnICg")]
    [DisplayName("New")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record New : ReportingTransactionType2Choice_
    #else
    public partial class New : ReportingTransactionType2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a New instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public New( System.String reqTransactionIdentification,System.String reqExecutingParty,System.String reqInvestmentPartyIndicator,System.String reqSubmittingParty,PartyIdentification79 reqBuyer,PartyIdentification79 reqSeller,SecuritiesTransactionTransmission2 reqOrderTransmission,SecuritiesTransaction1 reqTransaction,FinancialInstrumentAttributes4Choice_ reqFinancialInstrument,ExecutingParty1Choice_ reqExecutingPerson,SecuritiesTransactionIndicator2 reqAdditionalAttributes )
        {
            TransactionIdentification = reqTransactionIdentification;
            ExecutingParty = reqExecutingParty;
            InvestmentPartyIndicator = reqInvestmentPartyIndicator;
            SubmittingParty = reqSubmittingParty;
            Buyer = reqBuyer;
            Seller = reqSeller;
            OrderTransmission = reqOrderTransmission;
            Transaction = reqTransaction;
            FinancialInstrument = reqFinancialInstrument;
            ExecutingPerson = reqExecutingPerson;
            AdditionalAttributes = reqAdditionalAttributes;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the transaction.
        /// </summary>
        [IsoId("_XjVHgZ26Eeuwmdq0KtnICg")]
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
        /// </summary>
        [IsoId("_XjVHg526Eeuwmdq0KtnICg")]
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
        /// Indicates whether the reporting party is defined as an investment firm under the local regulation or not.
        /// </summary>
        [IsoId("_XjVHhZ26Eeuwmdq0KtnICg")]
        [DisplayName("Investment Party Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstmtPtyInd")]
        #endif
        [IsoXmlTag("InvstmtPtyInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator InvestmentPartyIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String InvestmentPartyIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String InvestmentPartyIndicator { get; init; } 
        #else
        public System.String InvestmentPartyIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Entity submitting the transaction report to the competent authority.
        /// </summary>
        [IsoId("_XjVHjZ26Eeuwmdq0KtnICg")]
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
        /// Identifies the acquirer of the legal title to the financial instrument.
        /// </summary>
        [IsoId("_XjVHj526Eeuwmdq0KtnICg")]
        [DisplayName("Buyer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Buyr")]
        #endif
        [IsoXmlTag("Buyr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification79 Buyer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification79 Buyer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification79 Buyer { get; init; } 
        #else
        public PartyIdentification79 Buyer { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the seller of the legal title to the financial instrument.
        /// </summary>
        [IsoId("_XjVHkZ26Eeuwmdq0KtnICg")]
        [DisplayName("Seller")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sellr")]
        #endif
        [IsoXmlTag("Sellr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification79 Seller { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification79 Seller { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification79 Seller { get; init; } 
        #else
        public PartyIdentification79 Seller { get; set; } 
        #endif
        
        /// <summary>
        /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
        /// Usage: Only applicable when the conditions for transmission are not satisfied.
        /// </summary>
        [IsoId("_XjVHk526Eeuwmdq0KtnICg")]
        [DisplayName("Order Transmission")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrdrTrnsmssn")]
        #endif
        [IsoXmlTag("OrdrTrnsmssn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
        #else
        public SecuritiesTransactionTransmission2 OrderTransmission { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the details of the reported transaction.
        /// </summary>
        [IsoId("_XjVHlZ26Eeuwmdq0KtnICg")]
        [DisplayName("Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tx")]
        #endif
        [IsoXmlTag("Tx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesTransaction1 Transaction { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesTransaction1 Transaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransaction1 Transaction { get; init; } 
        #else
        public SecuritiesTransaction1 Transaction { get; set; } 
        #endif
        
        /// <summary>
        /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
        /// </summary>
        [IsoId("_XjVHl526Eeuwmdq0KtnICg")]
        [DisplayName("Financial Instrument")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrm")]
        #endif
        [IsoXmlTag("FinInstrm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentAttributes4Choice_ FinancialInstrument { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentAttributes4Choice_ FinancialInstrument { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentAttributes4Choice_ FinancialInstrument { get; init; } 
        #else
        public FinancialInstrumentAttributes4Choice_ FinancialInstrument { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the person or algorithm which is responsible within the reporting party for the investment decision.
        /// </summary>
        [IsoId("_XjVHm526Eeuwmdq0KtnICg")]
        [DisplayName("Investment Decision Person")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstmtDcsnPrsn")]
        #endif
        [IsoXmlTag("InvstmtDcsnPrsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; } 
        #else
        public InvestmentParty1Choice_? InvestmentDecisionPerson { get; set; } 
        #endif
        
        /// <summary>
        /// Person or algorithm responsible for the execution of the transaction.
        /// </summary>
        [IsoId("_XjVHnZ26Eeuwmdq0KtnICg")]
        [DisplayName("Executing Person")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctgPrsn")]
        #endif
        [IsoXmlTag("ExctgPrsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExecutingParty1Choice_ ExecutingPerson { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExecutingParty1Choice_ ExecutingPerson { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExecutingParty1Choice_ ExecutingPerson { get; init; } 
        #else
        public ExecutingParty1Choice_ ExecutingPerson { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional indicators on the reported transaction.
        /// </summary>
        [IsoId("_XjVHn526Eeuwmdq0KtnICg")]
        [DisplayName("Additional Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlAttrbts")]
        #endif
        [IsoXmlTag("AddtlAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
        #else
        public SecuritiesTransactionIndicator2 AdditionalAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
        /// </summary>
        [IsoId("_XjVHoZ26Eeuwmdq0KtnICg")]
        [DisplayName("Technical Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechAttrbts")]
        #endif
        [IsoXmlTag("TechAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RecordTechnicalData5? TechnicalAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RecordTechnicalData5? TechnicalAttributes { get; init; } 
        #else
        public RecordTechnicalData5? TechnicalAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_XjVHo526Eeuwmdq0KtnICg")]
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
