// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement service for specific settlement types of requirements.
/// </summary>
[IsoId("_hKP4BWp_EemXfKijhrqa-Q")]
[DisplayName("Settlement Service Mode")]
public partial record SettlementServiceMode1
{
    #nullable enable
    
    /// <summary>
    /// Type of settlement service.
    /// </summary>
    [IsoId("_hKP4B2p_EemXfKijhrqa-Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Identification of settlement service.
    /// </summary>
    [IsoId("_hKP4CGp_EemXfKijhrqa-Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Short name of the Settlement Service.
    /// </summary>
    [IsoId("_hKP4CWp_EemXfKijhrqa-Q")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Priority to process a settlement.
    /// </summary>
    [IsoId("_hKP4Bmp_EemXfKijhrqa-Q")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; } 
    
    
    #nullable disable
    
}
