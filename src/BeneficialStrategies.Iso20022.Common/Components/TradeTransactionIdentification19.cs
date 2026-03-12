// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_d2cYkcgxEeuGrNSsxk3B0A")]
[DisplayName("Trade Transaction Identification")]
public partial record TradeTransactionIdentification19
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_d4KP0cgxEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_d4KP08gxEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Unique code identifying that the Financial counterparty responsible for reporting on behalf of the other counterparty.
    /// USAGE : In the case where a management company is responsible for reporting on behalf of an Undertaking for Collective Investment in Transferable Securities (UCITS), the unique code identifying that management company. In the case where an Alternative Investment Fund Manager (AIFM) is responsible for reporting on behalf of an Alternative Investment Fund (AIF), the unique code identifying that AIFM.
    /// </summary>
    [IsoId("_d4KP1cgxEeuGrNSsxk3B0A")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("_d4KP18gxEeuGrNSsxk3B0A")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_d4KP2cgxEeuGrNSsxk3B0A")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; } 
    
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_d4KP28gxEeuGrNSsxk3B0A")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_d4KP3cgxEeuGrNSsxk3B0A")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    
    
    #nullable disable
    
}
