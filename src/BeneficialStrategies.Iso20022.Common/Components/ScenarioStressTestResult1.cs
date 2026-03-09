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
/// Outcome of the application of a hypothetical scenario on the valuation of a set of portfolios of financial instruments.
/// </summary>
[IsoId("_vWmhcKs9Eeayv9XxdmMwKQ")]
[DisplayName("Scenario Stress Test Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ScenarioStressTestResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ScenarioStressTestResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ScenarioStressTestResult1( GenericIdentification168 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the stressed account.
    /// </summary>
    [IsoId("_MERKUKs_Eeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification168 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification168 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification168 Identification { get; init; } 
    #else
    public GenericIdentification168 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Result from the application of a stress test scenario to the positions in a cleared portfolio.
    /// </summary>
    [IsoId("_ZLzBQKs_Eeayv9XxdmMwKQ")]
    [DisplayName("Portfolio Stress Test Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflStrssTstRslt")]
    #endif
    [IsoXmlTag("PrtflStrssTstRslt")]
    public ValueList<PortfolioStressTestResult1> PortfolioStressTestResult { get; init; } = new ValueList<PortfolioStressTestResult1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ZLzBQKs_Eeayv9XxdmMwKQ
    
    
    #nullable disable
    
}
