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
[IsoId("_Qgcssb5aEeexmbB7KsjCwA")]
[DisplayName("Corporate Action General Information SD")]
public partial record CorporateActionGeneralInformationSD31
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_Qw_qIb5aEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_Qw_qI75aEeexmbB7KsjCwA")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification20 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_Qw_qMb5aEeexmbB7KsjCwA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    [IsoId("_Qw_qP75aEeexmbB7KsjCwA")]
    [DisplayName("Unallocated Details")]
    [IsoXmlTag("UallctdDtls")]
    public CorporateActionUnallocatedDetailsSD6? UnallocatedDetails { get; init; } 
    
    
    #nullable disable
    
}
