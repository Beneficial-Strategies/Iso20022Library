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
/// Indicates on an order that the trader wishes to display one price in the market but will accept trades at another price.
/// </summary>
[IsoId("_SyZ0PNp-Ed-ak6NoX_4Aeg_1464463754")]
[DisplayName("Discretion Instructions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DiscretionInstructions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DiscretionInstructions1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DiscretionInstructions1( ActiveCurrencyAndAmount reqOffset,System.String reqOffsetSign,TypeOfDiscretionPrice1Code reqRelatedPriceType,MoveType1Code reqMoveType,System.String reqLimitType,System.String reqRoundDirection,PriceProtectionScope2Code reqScope,OffsetType1Code reqOffsetType )
    {
        Offset = reqOffset;
        OffsetSign = reqOffsetSign;
        RelatedPriceType = reqRelatedPriceType;
        MoveType = reqMoveType;
        LimitType = reqLimitType;
        RoundDirection = reqRoundDirection;
        Scope = reqScope;
        OffsetType = reqOffsetType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information for the executing party about the price to be obtained for an order. It is expressed as an offset from a reference price such as the market price or last trade price.
    /// </summary>
    [IsoId("_SyZ0Pdp-Ed-ak6NoX_4Aeg_1506944896")]
    [DisplayName("Offset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Offset")]
    #endif
    [IsoXmlTag("Offset")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Offset { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Offset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Offset { get; init; } 
    #else
    public ActiveCurrencyAndAmount Offset { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the offset should be added or subtracted from the related price.
    /// </summary>
    [IsoId("_SyZ0Ptp-Ed-ak6NoX_4Aeg_1509714576")]
    [DisplayName("Offset Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffsetSgn")]
    #endif
    [IsoXmlTag("OffsetSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPlusOrMinusIndicator OffsetSign { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OffsetSign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OffsetSign { get; init; } 
    #else
    public System.String OffsetSign { get; set; } 
    #endif
    
    /// <summary>
    /// Identify the type of price an offset is related to. The offset can either be added or subtracted.
    /// </summary>
    [IsoId("_Syi-INp-Ed-ak6NoX_4Aeg_1505097016")]
    [DisplayName("Related Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPricTp")]
    #endif
    [IsoXmlTag("RltdPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfDiscretionPrice1Code RelatedPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfDiscretionPrice1Code RelatedPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfDiscretionPrice1Code RelatedPriceType { get; init; } 
    #else
    public TypeOfDiscretionPrice1Code RelatedPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Describes whether discretion price is static/fixed or floats.
    /// </summary>
    [IsoId("_Syi-Idp-Ed-ak6NoX_4Aeg_-1123942563")]
    [DisplayName("Move Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvTp")]
    #endif
    [IsoXmlTag("MvTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MoveType1Code MoveType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MoveType1Code MoveType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoveType1Code MoveType { get; init; } 
    #else
    public MoveType1Code MoveType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature of the resulting discretion price (e.g. or better limit, strict limit etc).
    /// </summary>
    [IsoId("_Syi-Itp-Ed-ak6NoX_4Aeg_-1110089593")]
    [DisplayName("Limit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtTp")]
    #endif
    [IsoXmlTag("LmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LimitType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LimitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LimitType { get; init; } 
    #else
    public System.String LimitType { get; set; } 
    #endif
    
    /// <summary>
    /// If the calculated discretion price is not a valid tick price, specifies how to round the price (e.g. to be more or less aggressive).
    /// </summary>
    [IsoId("_Syi-I9p-Ed-ak6NoX_4Aeg_-1098080503")]
    [DisplayName("Round Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndDrctn")]
    #endif
    [IsoXmlTag("RndDrctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RoundDirection { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RoundDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RoundDirection { get; init; } 
    #else
    public System.String RoundDirection { get; set; } 
    #endif
    
    /// <summary>
    /// The scope of &quot;related to&quot; price of the discretion (e.g. local, global etc).
    /// </summary>
    [IsoId("_Syi-JNp-Ed-ak6NoX_4Aeg_-1082381651")]
    [DisplayName("Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scp")]
    #endif
    [IsoXmlTag("Scp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceProtectionScope2Code Scope { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceProtectionScope2Code Scope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceProtectionScope2Code Scope { get; init; } 
    #else
    public PriceProtectionScope2Code Scope { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of Discretion Offset.
    /// </summary>
    [IsoId("_Syi-Jdp-Ed-ak6NoX_4Aeg_-980921869")]
    [DisplayName("Offset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffsetTp")]
    #endif
    [IsoXmlTag("OffsetTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OffsetType1Code OffsetType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OffsetType1Code OffsetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OffsetType1Code OffsetType { get; init; } 
    #else
    public OffsetType1Code OffsetType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
