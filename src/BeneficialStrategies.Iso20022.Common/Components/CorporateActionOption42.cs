// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_kKU0EQrAEeGFLZ_5tFfOnw")]
[DisplayName("Corporate Action Option")]
public partial record CorporateActionOption42
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_kKU0HwrAEeGFLZ_5tFfOnw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_kKU0KQrAEeGFLZ_5tFfOnw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption12Choice_ OptionType { get; init; } 
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is a quantity of securities instructed or a quantity to receive.
    /// </summary>
    [IsoId("_kKU0MwrAEeGFLZ_5tFfOnw")]
    [DisplayName("Instructed Or Quantity To Receive")]
    [IsoXmlTag("InstdOrQtyToRcv")]
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    
    
    #nullable disable
    
}
