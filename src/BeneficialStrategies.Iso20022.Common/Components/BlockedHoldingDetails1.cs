// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about a blocked holding.
/// </summary>
[IsoId("_GdlysxKeEeKj15WxqwlXPw")]
[DisplayName("Blocked Holding Details")]
public partial record BlockedHoldingDetails1
{
    #nullable enable
    
    /// <summary>
    /// Specifies how the blocked account holding is defined.
    /// </summary>
    [IsoId("_tExT0BKeEeKj15WxqwlXPw")]
    [DisplayName("Blocked Holding")]
    [IsoXmlTag("BlckdHldg")]
    public required Holding1Code BlockedHolding { get; init; } 
    
    /// <summary>
    /// When an account is blocked at the level of fund, partially, this is the number of units blocked.
    /// </summary>
    [IsoId("_RGi48BKfEeKj15WxqwlXPw")]
    [DisplayName("Partial Holding Units")]
    [IsoXmlTag("PrtlHldgUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PartialHoldingUnits { get; init; } 
    
    /// <summary>
    /// When an account is blocked at the level of fund, this specifies the certificate number of the blocked units.
    /// </summary>
    [IsoId("_ZwACEBKfEeKj15WxqwlXPw")]
    [DisplayName("Holding Certificate Number")]
    [IsoXmlTag("HldgCertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? HoldingCertificateNumber { get; init; } 
    
    
    #nullable disable
    
}
