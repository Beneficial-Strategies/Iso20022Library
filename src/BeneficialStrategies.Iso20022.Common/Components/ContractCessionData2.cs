// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract Cession Data2.
/// </summary>
[IsoId("_6sqpPzEyEe6g-ffJsqGiSA")]
[DisplayName("Contract Cession Data2")]
public partial record ContractCessionData2
{
    #nullable enable

    /// <summary>
    /// Document Date.
    /// </summary>
    [DisplayName("Document Date")]
    [IsoXmlTag("DocDt")]
    public IsoISODate? DocumentDate { get; init; } 

    /// <summary>
    /// Document Number.
    /// </summary>
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public IsoMax35Text? DocumentNumber { get; init; } 

    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required TradeParty6 Party { get; init; } 

    
    #nullable disable
    
}
