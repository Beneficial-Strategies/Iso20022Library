// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the implementation and version.
/// </summary>
[IsoId("_FaNY0RUVEeOIaq8KyCdIDQ")]
[DisplayName("Market Practice Version")]
public partial record MarketPracticeVersion1
{
    #nullable enable
    
    /// <summary>
    /// Market practice, for example, “UKTRANSFERS”, “FINDELSLT”.
    /// </summary>
    [IsoId("_W9gQcBUVEeOIaq8KyCdIDQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Name { get; init; } 
    
    /// <summary>
    /// Year and month, for example, 2013-06.
    /// </summary>
    [IsoId("_hDqoIBUVEeOIaq8KyCdIDQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? Date { get; init; } 
    
    /// <summary>
    /// Version of the market practice.
    /// </summary>
    [IsoId("_mP4OUBUVEeOIaq8KyCdIDQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; } 
    
    
    #nullable disable
    
}
