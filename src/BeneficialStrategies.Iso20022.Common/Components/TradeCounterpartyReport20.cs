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
/// Information related to parties in the contract.
/// </summary>
[IsoId("_tqiloQz1Ee2YoLD-1vFj0g")]
[DisplayName("Trade Counterparty Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCounterpartyReport20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCounterpartyReport20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCounterpartyReport20( Counterparty45 reqReportingCounterparty,Counterparty46 reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty to a derivative transaction who is fulfilling its reporting obligation in the present report.
    /// </summary>
    [IsoId("_trQXUQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty45 ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty45 ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty45 ReportingCounterparty { get; init; } 
    #else
    public Counterparty45 ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the other counterparty to a derivative transaction.
    /// </summary>
    [IsoId("_trQXUwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty46 OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty46 OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty46 OtherCounterparty { get; init; } 
    #else
    public Counterparty46 OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity [party] acting as an intermediary which [who] arranges the transaction for the reporting counterparty (“arranging broker”).
    /// </summary>
    [IsoId("_trQXVQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    #else
    public OrganisationIdentification15Choice_? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that ultimately submits the report to the trade repository.
    /// </summary>
    [IsoId("_trQXVwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Submitting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgAgt")]
    #endif
    [IsoXmlTag("SubmitgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? SubmittingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? SubmittingAgent { get; init; } 
    #else
    public OrganisationIdentification15Choice_? SubmittingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the clearing member through which a derivative transaction is cleared at a central counterparty (CCP).  The element applies to transactions under the agency clearing model and the principal clearing model.
    /// </summary>
    [IsoId("_trQXWQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification248Choice_? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification248Choice_? ClearingMember { get; init; } 
    #else
    public PartyIdentification248Choice_? ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the beneficiary of a derivative transaction, that is a party that is subject to the rights and obligations arising from the contract.
    /// ||Usage: In case of two occurances of beneficiary, the first iteration should always be the beneficiary 1 of the counterparty 1 and the second iteration is the beneficiary 2 of the counterparty 2. In case of single occurance of Beneficiary, RelationshipRecord should be provided.
    /// </summary>
    [IsoId("_trQXWwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<PartyIdentification248Choice_> Beneficiary { get; init; } = new ValueList<PartyIdentification248Choice_>(){};
    
    /// <summary>
    /// According to jurisdictional requirements, identification of the entity with the legal obligation or responsibility to report.
    /// </summary>
    [IsoId("_trQXXQz1Ee2YoLD-1vFj0g")]
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
    /// Identification of the entity that executed the transaction on behalf of the counterparty, and binds the counterparty to the terms of the transaction, but is not a broker.
    /// Usage: In case of two occurances of ExecutionAgent, the first iteration should always be the execution agent 1 of the counterparty 1 and the second iteration is the execution agent 2 of the counterparty 2. In case of single occurance of ExecutionAgent, RelationshipRecord should be provided.
    /// </summary>
    [IsoId("_U9tDoBZlEe27wrM4RUjLog")]
    [DisplayName("Execution Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnAgt")]
    #endif
    [IsoXmlTag("ExctnAgt")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<OrganisationIdentification15Choice_> ExecutionAgent { get; init; } = new ValueList<OrganisationIdentification15Choice_>(){};
    
    /// <summary>
    /// Specifies the relationship record between two parties part of the transaction.
    /// </summary>
    [IsoId("_NnAawCR6Ee2VuKUpJ7HXPg")]
    [DisplayName("Relationship Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltshRcrd")]
    #endif
    [IsoXmlTag("RltshRcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeCounterpartyRelationshipRecord1? RelationshipRecord { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyRelationshipRecord1? RelationshipRecord { get; init; } 
    #else
    public TradeCounterpartyRelationshipRecord1? RelationshipRecord { get; set; } 
    #endif
    
    
    #nullable disable
    
}
