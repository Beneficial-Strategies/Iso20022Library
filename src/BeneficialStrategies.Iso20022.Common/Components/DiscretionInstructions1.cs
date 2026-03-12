// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates on an order that the trader wishes to display one price in the market but will accept trades at another price.
/// </summary>
[IsoId("_SyZ0PNp-Ed-ak6NoX_4Aeg_1464463754")]
[DisplayName("Discretion Instructions")]
public partial record DiscretionInstructions1
{
    #nullable enable
    
    /// <summary>
    /// Information for the executing party about the price to be obtained for an order. It is expressed as an offset from a reference price such as the market price or last trade price.
    /// </summary>
    [IsoId("_SyZ0Pdp-Ed-ak6NoX_4Aeg_1506944896")]
    [DisplayName("Offset")]
    [IsoXmlTag("Offset")]
    public required ActiveCurrencyAndAmount Offset { get; init; } 
    
    /// <summary>
    /// Indicates whether the offset should be added or subtracted from the related price.
    /// </summary>
    [IsoId("_SyZ0Ptp-Ed-ak6NoX_4Aeg_1509714576")]
    [DisplayName("Offset Sign")]
    [IsoXmlTag("OffsetSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public required IsoPlusOrMinusIndicator OffsetSign { get; init; } 
    
    /// <summary>
    /// Identify the type of price an offset is related to. The offset can either be added or subtracted.
    /// </summary>
    [IsoId("_Syi-INp-Ed-ak6NoX_4Aeg_1505097016")]
    [DisplayName("Related Price Type")]
    [IsoXmlTag("RltdPricTp")]
    public required TypeOfDiscretionPrice1Code RelatedPriceType { get; init; } 
    
    /// <summary>
    /// Describes whether discretion price is static/fixed or floats.
    /// </summary>
    [IsoId("_Syi-Idp-Ed-ak6NoX_4Aeg_-1123942563")]
    [DisplayName("Move Type")]
    [IsoXmlTag("MvTp")]
    public required MoveType1Code MoveType { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the resulting discretion price (e.g. or better limit, strict limit etc).
    /// </summary>
    [IsoId("_Syi-Itp-Ed-ak6NoX_4Aeg_-1110089593")]
    [DisplayName("Limit Type")]
    [IsoXmlTag("LmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text LimitType { get; init; } 
    
    /// <summary>
    /// If the calculated discretion price is not a valid tick price, specifies how to round the price (e.g. to be more or less aggressive).
    /// </summary>
    [IsoId("_Syi-I9p-Ed-ak6NoX_4Aeg_-1098080503")]
    [DisplayName("Round Direction")]
    [IsoXmlTag("RndDrctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RoundDirection { get; init; } 
    
    /// <summary>
    /// The scope of &quot;related to&quot; price of the discretion (e.g. local, global etc).
    /// </summary>
    [IsoId("_Syi-JNp-Ed-ak6NoX_4Aeg_-1082381651")]
    [DisplayName("Scope")]
    [IsoXmlTag("Scp")]
    public required PriceProtectionScope2Code Scope { get; init; } 
    
    /// <summary>
    /// Describes the type of Discretion Offset.
    /// </summary>
    [IsoId("_Syi-Jdp-Ed-ak6NoX_4Aeg_-980921869")]
    [DisplayName("Offset Type")]
    [IsoXmlTag("OffsetTp")]
    public required OffsetType1Code OffsetType { get; init; } 
    
    
    #nullable disable
    
}
