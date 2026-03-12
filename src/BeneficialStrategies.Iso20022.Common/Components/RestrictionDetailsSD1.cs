// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restriction information details.
/// </summary>
[IsoId("_c1-rgMnIEeWGzao7PBKDrg")]
[DisplayName("Restriction Details SD")]
public partial record RestrictionDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// Type of restriction.
    /// </summary>
    [IsoId("_iS3K8MnIEeWGzao7PBKDrg")]
    [DisplayName("Restriction Type")]
    [IsoXmlTag("RstrctnTp")]
    public required GenericIdentification36 RestrictionType { get; init; } 
    
    /// <summary>
    /// Country in which the account owner has one&apos;s fiscal domicile.
    /// </summary>
    [IsoId("_n7yiUMnIEeWGzao7PBKDrg")]
    [DisplayName("Fiscal Domicile")]
    [IsoXmlTag("FsclDmcl")]
    public required CountryCode FiscalDomicile { get; init; } 
    
    /// <summary>
    /// Reference to the applicable restriction.
    /// </summary>
    [IsoId("_3RQ3gMnIEeWGzao7PBKDrg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    
    #nullable disable
    
}
