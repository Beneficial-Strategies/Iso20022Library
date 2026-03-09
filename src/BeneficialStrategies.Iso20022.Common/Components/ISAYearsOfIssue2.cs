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
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_SvuTrNp-Ed-ak6NoX_4Aeg_-594935338")]
[DisplayName("ISA Years Of Issue")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISAYearsOfIssue2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_SvuTrdp-Ed-ak6NoX_4Aeg_-594935302")]
    [DisplayName("Current Year Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrTp")]
    #endif
    [IsoXmlTag("CurYrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISAType2Code? CurrentYearType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISAType2Code? CurrentYearType { get; init; } 
    #else
    public ISAType2Code? CurrentYearType { get; set; } 
    #endif
    
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_Sv3dkNp-Ed-ak6NoX_4Aeg_-594934953")]
    [DisplayName("Extended Current Year Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedCurYrTp")]
    #endif
    [IsoXmlTag("XtndedCurYrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedCurrentYearType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedCurrentYearType { get; init; } 
    #else
    public System.String? ExtendedCurrentYearType { get; set; } 
    #endif
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_Sv3dkdp-Ed-ak6NoX_4Aeg_524128518")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYearChoice_? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYearChoice_? PreviousYears { get; init; } 
    #else
    public PreviousYearChoice_? PreviousYears { get; set; } 
    #endif
    
    
    #nullable disable
    
}
