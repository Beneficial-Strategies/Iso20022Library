// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that describes a netting cut off held at a central system.
/// </summary>
[IsoId("_WkhLEJVIEeaYkf5FCqYMeA")]
[DisplayName("Cut Off")]
public partial record CutOff1
{
    #nullable enable
    
    /// <summary>
    /// Identification for the updated netting cut off.
    /// </summary>
    [IsoId("_hrAdUZnoEeaKH-pm9fIa8w")]
    [DisplayName("Cut Off Update Identification")]
    [IsoXmlTag("CutOffUpdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CutOffUpdateIdentification { get; init; } 
    
    /// <summary>
    /// Currency linked to the netting cut off.
    /// </summary>
    [IsoId("_yTThwZnnEeaKH-pm9fIa8w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Cut off time value for the netting cut off.
    /// </summary>
    [IsoId("_tbaqUJVIEeaYkf5FCqYMeA")]
    [DisplayName("Cut Off Time")]
    [IsoXmlTag("CutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime CutOffTime { get; init; } 
    
    /// <summary>
    /// Specifies the offset in business days from the value date from which the netting cut off is to be applied.
    /// </summary>
    [IsoId("_V7THkJVLEeaYkf5FCqYMeA")]
    [DisplayName("Value Date Offset")]
    [IsoXmlTag("ValDtOffset")]
    [IsoSimpleType(IsoSimpleType.DateOffsetText)]
    public required IsoDateOffsetText ValueDateOffset { get; init; } 
    
    
    #nullable disable
    
}
