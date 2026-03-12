// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about of a list that must be executed.
/// </summary>
[IsoId("_SzmHCNp-Ed-ak6NoX_4Aeg_922397507")]
[DisplayName("List Execution")]
public partial record ListExecution1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_SzmHCdp-Ed-ak6NoX_4Aeg_991661320")]
    [DisplayName("List Identification")]
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ListIdentification { get; init; } 
    
    /// <summary>
    /// Identifies a bid made by a client, to which the list is associated.
    /// </summary>
    [IsoId("_SzmHCtp-Ed-ak6NoX_4Aeg_1792356567")]
    [DisplayName("Client Bid Identification")]
    [IsoXmlTag("ClntBidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientBidIdentification { get; init; } 
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_SzvQ8Np-Ed-ak6NoX_4Aeg_348987448")]
    [DisplayName("Bid Identification")]
    [IsoXmlTag("BidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BidIdentification { get; init; } 
    
    
    #nullable disable
    
}
