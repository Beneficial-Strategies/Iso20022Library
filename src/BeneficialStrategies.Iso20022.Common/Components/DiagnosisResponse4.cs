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
/// Content of the Diagnosis Response message.
/// </summary>
[IsoId("_sVO1MU6rEeyGi9JAv6wq7Q")]
[DisplayName("Diagnosis Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DiagnosisResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_sbX5cU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Logged Sale Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LggdSaleId")]
    #endif
    [IsoXmlTag("LggdSaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LoggedSaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LoggedSaleIdentification { get; init; } 
    #else
    public System.String? LoggedSaleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_sbX5c06rEeyGi9JAv6wq7Q")]
    [DisplayName("POI Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POISts")]
    #endif
    [IsoXmlTag("POISts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReportContent11? POIStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReportContent11? POIStatus { get; init; } 
    #else
    public StatusReportContent11? POIStatus { get; set; } 
    #endif
    
    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_sbX5dU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Host Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstSts")]
    #endif
    [IsoXmlTag("HstSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HostStatus1? HostStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HostStatus1? HostStatus { get; init; } 
    #else
    public HostStatus1? HostStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
