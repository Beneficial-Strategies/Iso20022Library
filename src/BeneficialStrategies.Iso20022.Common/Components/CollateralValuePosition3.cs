// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the collateral value position/balance.
/// </summary>
[IsoId("_EP0opTpyEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Position")]
public partial record CollateralValuePosition3
{
    #nullable enable
    
    /// <summary>
    /// Date and time when the data was last accessed.
    /// </summary>
    [IsoId("_EbS40TpyEemk2e6qGBk8IQ")]
    [DisplayName("Data Access Time")]
    [IsoXmlTag("DataAccsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DataAccessTime { get; init; } 
    
    /// <summary>
    /// Total value of the collateral valuation.
    /// </summary>
    [IsoId("_EbS40zpyEemk2e6qGBk8IQ")]
    [DisplayName("Total Collateral Valuation")]
    [IsoXmlTag("TtlCollValtn")]
    public ActiveCurrencyAndAmount? TotalCollateralValuation { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the securities account.
    /// </summary>
    [IsoId("_EbS41TpyEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account")]
    [IsoXmlTag("SctiesAcct")]
    public SecuritiesAccount19? SecuritiesAccount { get; init; } 
    
    /// <summary>
    /// Unique identification, as known by the account owner, to unambiguously identify the securities on which the collateral value position is requested.
    /// </summary>
    [IsoId("_EbS41zpyEemk2e6qGBk8IQ")]
    [DisplayName("Securities")]
    [IsoXmlTag("Scties")]
    public SecurityCharacteristics3? Securities { get; init; } 
    
    
    #nullable disable
    
}
