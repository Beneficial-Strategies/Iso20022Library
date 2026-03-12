// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
[IsoId("_Rg4X8Z2IEeW-bsa36JFb9A")]
[DisplayName("Corporate Action General Information SD")]
public partial record CorporateActionGeneralInformationSD20
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_R3C1MZ2IEeW-bsa36JFb9A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_R3C1M52IEeW-bsa36JFb9A")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification15 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_R3C1QZ2IEeW-bsa36JFb9A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    [IsoId("_R3C1T52IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Details")]
    [IsoXmlTag("UallctdDtls")]
    public CorporateActionUnallocatedDetailsSD4? UnallocatedDetails { get; init; } 
    
    
    #nullable disable
    
}
