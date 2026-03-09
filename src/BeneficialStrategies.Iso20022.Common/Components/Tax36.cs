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
/// Information about tax.
/// </summary>
[IsoId("_VpKZIHVYEeiiHo4Gse0d2w")]
[DisplayName("Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax36
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax36 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax36( DateQuarter1Choice_ reqDateOrPeriod )
    {
        DateOrPeriod = reqDateOrPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date or quarter of the tax year on which tax for the financial instrument is based or calculated.
    /// </summary>
    [IsoId("_Zlx_sHVYEeiiHo4Gse0d2w")]
    [DisplayName("Date Or Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOrPrd")]
    #endif
    [IsoXmlTag("DtOrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateQuarter1Choice_ DateOrPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateQuarter1Choice_ DateOrPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateQuarter1Choice_ DateOrPeriod { get; init; } 
    #else
    public DateQuarter1Choice_ DateOrPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about tax.
    /// </summary>
    [IsoId("_fQMk0HVYEeiiHo4Gse0d2w")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
