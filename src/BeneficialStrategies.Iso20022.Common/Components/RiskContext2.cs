// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the risk associated with the transaction.
/// </summary>
[IsoId("_VFt7wcStEeuBjv5G5kw00g")]
[DisplayName("Risk Context")]
public partial record RiskContext2
{
    #nullable enable
    
    /// <summary>
    /// Input data to be considered in a risk assessment.
    /// </summary>
    [IsoId("_VKsiYcStEeuBjv5G5kw00g")]
    [DisplayName("Risk Input Data")]
    [IsoXmlTag("RskInptData")]
    public RiskInputData1? RiskInputData { get; init; } 
    
    /// <summary>
    /// Indicates to the card issuer the level of risk associated with the transaction.
    /// </summary>
    [IsoId("_VKtJccStEeuBjv5G5kw00g")]
    [DisplayName("Risk Assessment")]
    [IsoXmlTag("RskAssmnt")]
    public RiskAssessment2? RiskAssessment { get; init; } 
    
    
    #nullable disable
    
}
