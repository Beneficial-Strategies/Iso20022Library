// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_xpfEAc29Eeu7SNBdMhkjcA")]
[DisplayName("Trade Transaction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransactionIdentification20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransactionIdentification20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransactionIdentification20( OrganisationIdentification15Choice_ reqReportingCounterparty,PartyIdentification236Choice_ reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_AG25QM3OEeuiU4QSC_BouQ")]
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
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_xrWFMc29Eeu7SNBdMhkjcA")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    #else
    public OrganisationIdentification15Choice_ ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_xrWFM829Eeu7SNBdMhkjcA")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    #else
    public PartyIdentification236Choice_ OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying that counterparty in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_K00cINAQEeuvMdMKUKkEeQ")]
    [DisplayName("Entity Responsible For Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NttyRspnsblForRpt")]
    #endif
    [IsoXmlTag("NttyRspnsblForRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    #else
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; set; } 
    #endif
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("_xrWFNc29Eeu7SNBdMhkjcA")]
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
    [IsoId("_xrWFN829Eeu7SNBdMhkjcA")]
    [DisplayName("Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmt")]
    #endif
    [IsoXmlTag("MstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement7? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement7? MasterAgreement { get; init; } 
    #else
    public MasterAgreement7? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_xrWFOc29Eeu7SNBdMhkjcA")]
    [DisplayName("Agent Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtLndr")]
    #endif
    [IsoXmlTag("AgtLndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    #else
    public OrganisationIdentification15Choice_? AgentLender { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_xrWFO829Eeu7SNBdMhkjcA")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    #else
    public OrganisationIdentification15Choice_? TripartyAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
