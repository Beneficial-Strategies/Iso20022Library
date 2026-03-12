// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting derivatives on a credit default swap index.
/// </summary>
[IsoId("_xtQzi35eEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Derivative")]
public partial record CreditDefaultSwapDerivative3
{
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying index.
    /// </summary>
    [IsoId("_x6DSUX5eEea2k7EBUopqxw")]
    [DisplayName("Underlying Index Identification")]
    [IsoXmlTag("UndrlygIndxId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; } 
    
    /// <summary>
    /// To be populated for derivatives on a CDS index with the standardized name of the index.
    /// </summary>
    [IsoId("_x6DSU35eEea2k7EBUopqxw")]
    [DisplayName("Index Name")]
    [IsoXmlTag("IndxNm")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    public required IsoMax25Text IndexName { get; init; } 
    
    /// <summary>
    /// Describes the Index specific details the derivative is being made on.
    /// </summary>
    [IsoId("_x6DSVX5eEea2k7EBUopqxw")]
    [DisplayName("Index")]
    [IsoXmlTag("Indx")]
    public required CreditDefaultSwapIndex2 Index { get; init; } 
    
    
    #nullable disable
    
}
