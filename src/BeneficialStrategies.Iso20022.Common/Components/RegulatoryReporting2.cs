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
[IsoId("_SnYP89p-Ed-ak6NoX_4Aeg_-2022088805")]
[DisplayName("Regulatory Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryReporting2
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
    [IsoId("_SnYP9Np-Ed-ak6NoX_4Aeg_-1566793972")]
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
    [IsoId("_SnYP9dp-Ed-ak6NoX_4Aeg_-688527268")]
    [DisplayName("Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authrty")]
    #endif
    [IsoXmlTag("Authrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryAuthority? Authority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryAuthority? Authority { get; init; } 
    #else
    public RegulatoryAuthority? Authority { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the regulatory reporting information.
    /// </summary>
    [IsoId("_SnYP9tp-Ed-ak6NoX_4Aeg_2118187672")]
    [DisplayName("Regulatory Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryDtls")]
    #endif
    [IsoXmlTag("RgltryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StructuredRegulatoryReporting2? RegulatoryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StructuredRegulatoryReporting2? RegulatoryDetails { get; init; } 
    #else
    public StructuredRegulatoryReporting2? RegulatoryDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
