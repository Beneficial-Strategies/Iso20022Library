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
namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification1Choice
{
    /// <summary>
    /// Provides identification of the securities financial transaction.
    /// </summary>
    [IsoId("_lv0vQK7LEemZxoEFHjN-AQ")]
    [DisplayName("Transaction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Transaction : TransactionIdentification1Choice_
    #else
    public partial class Transaction : TransactionIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Transaction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Transaction( OrganisationIdentification9Choice_ reqReportingCounterparty,OrganisationIdentification9Choice_ reqOtherCounterparty )
        {
            ReportingCounterparty = reqReportingCounterparty;
            OtherCounterparty = reqOtherCounterparty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique code identifying the reporting counterparty.
        /// </summary>
        [IsoId("_CYn3gaxiEem81-uIvTF5rQ")]
        [DisplayName("Reporting Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptgCtrPty")]
        #endif
        [IsoXmlTag("RptgCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
        #else
        public OrganisationIdentification9Choice_ ReportingCounterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
        /// </summary>
        [IsoId("_CYn3g6xiEem81-uIvTF5rQ")]
        [DisplayName("Other Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrCtrPty")]
        #endif
        [IsoXmlTag("OthrCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
        #else
        public OrganisationIdentification9Choice_ OtherCounterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the counterparty.
        /// </summary>
        [IsoId("_CYn3haxiEem81-uIvTF5rQ")]
        [DisplayName("Unique Trade Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTradIdr")]
        #endif
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UniqueTradeIdentifier { get; init; } 
        #else
        public System.String? UniqueTradeIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Details related to the master agreement.
        /// </summary>
        [IsoId("_CYn3h6xiEem81-uIvTF5rQ")]
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
        /// Identification of the agent lender involved in the securities lending transaction.
        /// </summary>
        [IsoId("_FbGxEKxiEem81-uIvTF5rQ")]
        [DisplayName("Agent Lender")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AgtLndr")]
        #endif
        [IsoXmlTag("AgtLndr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationIdentification9Choice_? AgentLender { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification9Choice_? AgentLender { get; init; } 
        #else
        public OrganisationIdentification9Choice_? AgentLender { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the third party that administers the transaction.
        /// </summary>
        [IsoId("_GhJMEKxiEem81-uIvTF5rQ")]
        [DisplayName("Triparty Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrptyAgt")]
        #endif
        [IsoXmlTag("TrptyAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationIdentification9Choice_? TripartyAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification9Choice_? TripartyAgent { get; init; } 
        #else
        public OrganisationIdentification9Choice_? TripartyAgent { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
