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
/// Provides the details for a call/put option.
/// </summary>
[IsoId("_TvjDULtJEeSmENFdxjMqzQ")]
[DisplayName("Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Option12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Option12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Option12( OptionType1Code reqType,OptionDateOrPeriod1Choice_ reqDateOrPeriod )
    {
        Type = reqType;
        DateOrPeriod = reqDateOrPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies whether the instrument has a call option or a put option. If the instrument contains both options, i.e. a call and a put, both the call option and the put option have to be reported.
    /// </summary>
    [IsoId("_an7QYLtJEeSmENFdxjMqzQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType1Code Type { get; init; } 
    #else
    public OptionType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the exercise date or notice period for a call/put option.
    /// </summary>
    [IsoId("_VQ8yMTU7EeWITbq5W8H-2w")]
    [DisplayName("Date Or Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOrPrd")]
    #endif
    [IsoXmlTag("DtOrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionDateOrPeriod1Choice_ DateOrPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionDateOrPeriod1Choice_ DateOrPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionDateOrPeriod1Choice_ DateOrPeriod { get; init; } 
    #else
    public OptionDateOrPeriod1Choice_ DateOrPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
