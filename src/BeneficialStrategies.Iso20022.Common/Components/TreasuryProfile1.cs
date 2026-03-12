// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Treasury trading profile.
/// </summary>
[IsoId("_BzjroCDSEeWCLu74WLgP4w")]
[DisplayName("Treasury Profile")]
public partial record TreasuryProfile1
{
    #nullable enable
    
    /// <summary>
    /// Execution date of treasury bond trade.
    /// </summary>
    [IsoId("_IENKUCDSEeWCLu74WLgP4w")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    /// <summary>
    /// Type of party that performs trading operations, for example, investor or custodian.
    /// </summary>
    [IsoId("_KVaX8CDSEeWCLu74WLgP4w")]
    [DisplayName("Trader Type")]
    [IsoXmlTag("TradrTp")]
    public required PartyRole5Choice_ TraderType { get; init; } 
    
    /// <summary>
    /// Tax rate.
    /// </summary>
    [IsoId("_79wgcCDSEeWCLu74WLgP4w")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    
    #nullable disable
    
}
