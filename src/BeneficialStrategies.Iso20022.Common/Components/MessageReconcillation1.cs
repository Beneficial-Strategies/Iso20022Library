// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains message reconciliation data.
/// </summary>
[IsoId("_rxPTtsyxEeiqqJhU2tqK8A")]
[DisplayName("Message Reconcillation")]
public partial record MessageReconcillation1
{
    #nullable enable
    
    /// <summary>
    /// Contains the reconciliation message type.
    /// </summary>
    [IsoId("_rxPTt8yxEeiqqJhU2tqK8A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReconciliationMessageType1Code Type { get; init; } 
    
    /// <summary>
    /// Other reconciliation message type defined at national or private level.
    /// </summary>
    [IsoId("_rxPTuMyxEeiqqJhU2tqK8A")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_rxPTucyxEeiqqJhU2tqK8A")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; } 
    
    
    #nullable disable
    
}
