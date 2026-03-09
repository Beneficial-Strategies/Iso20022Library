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
/// Data related specifically to counterparty.
/// </summary>
[IsoId("_CGXsEaoAEemdLtwzt4CWxg")]
[DisplayName("Counterparty Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyData60
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyData60 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyData60( System.DateTime reqReportingDateTime,OrganisationIdentification9Choice_ reqReportSubmittingEntity )
    {
        ReportingDateTime = reqReportingDateTime;
        ReportSubmittingEntity = reqReportSubmittingEntity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_CNhc8aoAEemdLtwzt4CWxg")]
    [DisplayName("Reporting Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDtTm")]
    #endif
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReportingDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ReportingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReportingDateTime { get; init; } 
    #else
    public System.DateTime ReportingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_CNhc86oAEemdLtwzt4CWxg")]
    [DisplayName("Report Submitting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSubmitgNtty")]
    #endif
    [IsoXmlTag("RptSubmitgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; } 
    #else
    public OrganisationIdentification9Choice_ ReportSubmittingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to counterparties.
    /// </summary>
    [IsoId("_CNhc9aoAEemdLtwzt4CWxg")]
    [DisplayName("Counterparty Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyData")]
    #endif
    [IsoXmlTag("CtrPtyData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartyData61> CounterpartyData { get; init; } = new ValueList<CounterpartyData61>(){};
    
    
    #nullable disable
    
}
