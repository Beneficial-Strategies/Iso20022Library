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
/// Compares information related to both sides of a loan.
/// </summary>
[IsoId("_bHPnAKxaEem81-uIvTF5rQ")]
[DisplayName("Counterparty Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyMatchingCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the reporting counterparties are matching or not.
    /// </summary>
    [IsoId("_KrOioa-eEemF0ZVFnxVu4g")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification1? ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification1? ReportingCounterparty { get; init; } 
    #else
    public CompareOrganisationIdentification1? ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the other counterparties are matching or not.
    /// </summary>
    [IsoId("_2BxTwKxaEem81-uIvTF5rQ")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification1? OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification1? OtherCounterparty { get; init; } 
    #else
    public CompareOrganisationIdentification1? OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the counterparty side are matching or not.
    /// </summary>
    [IsoId("_qzbzEKxaEem81-uIvTF5rQ")]
    [DisplayName("Counterparty Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySd")]
    #endif
    [IsoXmlTag("CtrPtySd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareCounterpartySide1? CounterpartySide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareCounterpartySide1? CounterpartySide { get; init; } 
    #else
    public CompareCounterpartySide1? CounterpartySide { get; set; } 
    #endif
    
    
    #nullable disable
    
}
