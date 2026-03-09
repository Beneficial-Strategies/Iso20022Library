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
/// Data specific to counterparties.
/// </summary>
[IsoId("_CRJNUcgtEeuGrNSsxk3B0A")]
[DisplayName("Counterparty Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyData86
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of information identifying the reporting counterparty.
    /// </summary>
    [IsoId("_CSkJo8gtEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyIdentification10? ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyIdentification10? ReportingCounterparty { get; init; } 
    #else
    public CounterpartyIdentification10? ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to other counterparties and related information.
    /// </summary>
    [IsoId("_CSkJpcgtEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? OtherCounterparty { get; init; } 
    #else
    public OrganisationIdentification15Choice_? OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if a triparty agent is involved in the transaction.
    /// </summary>
    [IsoId("_CSkJp8gtEeuGrNSsxk3B0A")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgent { get; init; } 
    #else
    public System.String? TripartyAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the agent lender is involved in the securities lending transaction.
    /// </summary>
    [IsoId("_CSkJqcgtEeuGrNSsxk3B0A")]
    [DisplayName("Agent Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtLndr")]
    #endif
    [IsoXmlTag("AgtLndr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AgentLender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentLender { get; init; } 
    #else
    public System.String? AgentLender { get; set; } 
    #endif
    
    
    #nullable disable
    
}
