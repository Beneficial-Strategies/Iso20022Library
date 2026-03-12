// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier for a list as assigned by institution, used to associate multiple individual orders. Uniqueness must be guaranteed within a single trading day. Institutions which generate multi-day orders should consider embedding a date to assure uniqueness across days.
/// </summary>
[IsoId("_SzmHBtp-Ed-ak6NoX_4Aeg_1241706785")]
[DisplayName("List Identification")]
public partial record ListIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_SzmHB9p-Ed-ak6NoX_4Aeg_1303584173")]
    [DisplayName("List Identification")]
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ListIdentification { get; init; } 
    
    
    #nullable disable
    
}
