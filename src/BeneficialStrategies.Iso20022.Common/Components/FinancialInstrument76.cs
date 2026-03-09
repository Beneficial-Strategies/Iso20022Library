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
/// Identifying features of a financial instrument that is a sub-set of an investment fund.
/// </summary>
[IsoId("_XHDzMf1PEeixXcHVEYIW2g")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument76
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_XuVOkf1PEeixXcHVEYIW2g")]
    [DisplayName("Supplementary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryId")]
    #endif
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? SupplementaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupplementaryIdentification { get; init; } 
    #else
    public System.String? SupplementaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [IsoId("_XuVOk_1PEeixXcHVEYIW2g")]
    [DisplayName("Securities Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesForm")]
    #endif
    [IsoXmlTag("SctiesForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #else
    public FormOfSecurity1Code? SecuritiesForm { get; set; } 
    #endif
    
    /// <summary>
    /// Features of units offered by a fund. for example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_XuVOlf1PEeixXcHVEYIW2g")]
    [DisplayName("Class Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssTp")]
    #endif
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? ClassType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassType { get; init; } 
    #else
    public System.String? ClassType { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_XuVOl_1PEeixXcHVEYIW2g")]
    [DisplayName("Distribution Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnPlcy")]
    #endif
    [IsoXmlTag("DstrbtnPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code? DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_XuVOmf1PEeixXcHVEYIW2g")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityClassificationType3Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityClassificationType3Choice_? ClassificationType { get; init; } 
    #else
    public SecurityClassificationType3Choice_? ClassificationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
