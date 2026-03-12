// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains amount details for a specific type of charge.
/// </summary>
[IsoId("_trtR1vfeEei89sMSHxl1ew")]
[DisplayName("Amount")]
public partial record Amount12
{
    #nullable enable
    
    /// <summary>
    /// Type of hours worked. 
    /// </summary>
    [IsoId("_trtR2_feEei89sMSHxl1ew")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TemporaryServicesCharge1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of hours worked. 
    /// </summary>
    [IsoId("_trtR2PfeEei89sMSHxl1ew")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Contains the rate per hour. 
    /// </summary>
    [IsoId("_trtR2vfeEei89sMSHxl1ew")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; } 
    
    /// <summary>
    /// Contains the number of hours worked. 
    /// </summary>
    [IsoId("_trtR2ffeEei89sMSHxl1ew")]
    [DisplayName("Hours")]
    [IsoXmlTag("Hrs")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? Hours { get; init; } 
    
    
    #nullable disable
    
}
