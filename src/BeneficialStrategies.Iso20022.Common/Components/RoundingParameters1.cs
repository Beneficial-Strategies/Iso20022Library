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
/// Parameters applied to a fractional number.
/// </summary>
[IsoId("_QRxDcNp-Ed-ak6NoX_4Aeg_-1749123923")]
[DisplayName("Rounding Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RoundingParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RoundingParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RoundingParameters1( RoundingDirection1Code reqRoundingDirection )
    {
        RoundingDirection = reqRoundingDirection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Float value specifying the value to which rounding is required, eg, 10 means round to a multiple of 10 units/shares, 0.5 means round to a multiple of 0.5 units/shares.
    /// </summary>
    [IsoId("_QRxDcdp-Ed-ak6NoX_4Aeg_-1749123921")]
    [DisplayName("Rounding Modulus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgMdlus")]
    #endif
    [IsoXmlTag("RndgMdlus")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? RoundingModulus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RoundingModulus { get; init; } 
    #else
    public System.UInt64? RoundingModulus { get; set; } 
    #endif
    
    /// <summary>
    /// Rounding direction applied to fractional numbers, eg, round up.
    /// </summary>
    [IsoId("_QRxDctp-Ed-ak6NoX_4Aeg_-1749123920")]
    [DisplayName("Rounding Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgDrctn")]
    #endif
    [IsoXmlTag("RndgDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RoundingDirection1Code RoundingDirection { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RoundingDirection1Code RoundingDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection1Code RoundingDirection { get; init; } 
    #else
    public RoundingDirection1Code RoundingDirection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
