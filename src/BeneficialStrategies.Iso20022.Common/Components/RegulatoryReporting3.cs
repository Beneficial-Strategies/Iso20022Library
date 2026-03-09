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
/// Information needed due to regulatory and/or statutory requirements.
/// </summary>
[IsoId("_SnYP99p-Ed-ak6NoX_4Aeg_-1655670600")]
[DisplayName("Regulatory Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryReporting3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_SnYP-Np-Ed-ak6NoX_4Aeg_-1655670598")]
    [DisplayName("Debit Credit Reporting Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtCdtRptgInd")]
    #endif
    [IsoXmlTag("DbtCdtRptgInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; init; } 
    #else
    public RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_SnhZ4Np-Ed-ak6NoX_4Aeg_-1655670538")]
    [DisplayName("Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authrty")]
    #endif
    [IsoXmlTag("Authrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryAuthority2? Authority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryAuthority2? Authority { get; init; } 
    #else
    public RegulatoryAuthority2? Authority { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide details on the regulatory reporting information.
    /// </summary>
    [IsoId("_SnhZ4dp-Ed-ak6NoX_4Aeg_-1655670493")]
    [DisplayName("Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dtls")]
    #endif
    [IsoXmlTag("Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StructuredRegulatoryReporting3? Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StructuredRegulatoryReporting3? Details { get; init; } 
    #else
    public StructuredRegulatoryReporting3? Details { get; set; } 
    #endif
    
    
    #nullable disable
    
}
