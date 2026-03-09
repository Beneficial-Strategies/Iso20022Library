// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the risk associated with the transaction.
/// </summary>
[IsoId("_VFt7wcStEeuBjv5G5kw00g")]
[DisplayName("Risk Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RiskContext2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Input data to be considered in a risk assessment.
    /// </summary>
    [IsoId("_VKsiYcStEeuBjv5G5kw00g")]
    [DisplayName("Risk Input Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskInptData")]
    #endif
    [IsoXmlTag("RskInptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskInputData1? RiskInputData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskInputData1? RiskInputData { get; init; } 
    #else
    public RiskInputData1? RiskInputData { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates to the card issuer the level of risk associated with the transaction.
    /// </summary>
    [IsoId("_VKtJccStEeuBjv5G5kw00g")]
    [DisplayName("Risk Assessment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskAssmnt")]
    #endif
    [IsoXmlTag("RskAssmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskAssessment2? RiskAssessment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskAssessment2? RiskAssessment { get; init; } 
    #else
    public RiskAssessment2? RiskAssessment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
