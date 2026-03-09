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
/// Defines the status of an investigation case.
/// </summary>
[IsoId("_T-GLS9p-Ed-ak6NoX_4Aeg_-1949574113")]
[DisplayName("Case Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CaseStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CaseStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CaseStatus2( System.DateTime reqDateTime,CaseStatus2Code reqCaseStatus )
    {
        DateTime = reqDateTime;
        CaseStatus = reqCaseStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time of the status.
    /// </summary>
    [IsoId("_T-GLTNp-Ed-ak6NoX_4Aeg_-1949574096")]
    [DisplayName("Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTm")]
    #endif
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DateTime { get; init; } 
    #else
    public System.DateTime DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the case.
    /// </summary>
    [IsoId("_T-P8QNp-Ed-ak6NoX_4Aeg_-1949574078")]
    [DisplayName("Case Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CaseSts")]
    #endif
    [IsoXmlTag("CaseSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseStatus2Code CaseStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseStatus2Code CaseStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseStatus2Code CaseStatus { get; init; } 
    #else
    public CaseStatus2Code CaseStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Free text justification of the status.
    /// </summary>
    [IsoId("_T-P8Qdp-Ed-ak6NoX_4Aeg_-1949574053")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
