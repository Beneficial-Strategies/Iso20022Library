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
/// Date and date parameters.
/// </summary>
[IsoId("_oxDxcDceEeOA3chqL9a4Rw")]
[DisplayName("Effective Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EffectiveDate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EffectiveDate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EffectiveDate1( System.DateOnly reqEffectiveDate )
    {
        EffectiveDate = reqEffectiveDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the SSI is effective. If the SSI is effective on a future date, then the date must be provided.
    /// </summary>
    [IsoId("_BjtLsDcfEeOA3chqL9a4Rw")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate EffectiveDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly EffectiveDate { get; init; } 
    #else
    public System.DateOnly EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the SSI update effective date is to be applied.
    /// </summary>
    [IsoId("_NXDd8DcfEeOA3chqL9a4Rw")]
    [DisplayName("Effective Date Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDtParam")]
    #endif
    [IsoXmlTag("FctvDtParam")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalEffectiveDateParameter1Code? EffectiveDateParameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEffectiveDateParameter1Code? EffectiveDateParameter { get; init; } 
    #else
    public ExternalEffectiveDateParameter1Code? EffectiveDateParameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
