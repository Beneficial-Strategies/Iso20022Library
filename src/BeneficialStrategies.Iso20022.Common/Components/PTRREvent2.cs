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
/// Information if contract results from a post trade risk reduction operation.
/// </summary>
[IsoId("_1GhnIfbdEeyInphUKJZxtQ")]
[DisplayName("PTRR Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PTRREvent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PTRREvent2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PTRREvent2( RiskReductionService1Code reqTechnique )
    {
        Technique = reqTechnique;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicator of a type of a post trade risk reduction operation for the purpose of reporting. 
    /// Portfolio Compression without a third-party service provider: An arrangement to reduce risk in existing portfolios of trades using non-price forming trades mainly to reduce notional amount outstanding, the number of transactions or otherwise harmonise the terms, by wholly or partially terminate trades and commonly to replace the terminated derivatives with new replacement trades.
    /// Portfolio Compression with a third-party service provider or CCP: A post trade risk reduction service provided by a service provider or CCP to reduce risk in existing portfolios of trades using non-price forming trades mainly to reduce notional amount outstanding, the number of transactions or otherwise harmonise the terms, by wholly or partially terminate trades and commonly to replace the terminated derivatives with new replacement trades.
    /// Portfolio Rebalancing/Margin management: A PTRR service provided by a service provider to reduce risk in an existing portfolio of trades by adding new non-price forming trades and where no existing trades in the portfolio are terminated or replaced and the notional is increased rather than decreased.
    /// Other Portfolio post trade risk reduction services: A post trade risk reduction service provided by a service provider to reduce risk in existing portfolios of trades using non-price forming trades and where such service does not qualify as Portfolio Compression or Portfolio Rebalancing.
    /// </summary>
    [IsoId("_1HX7sfbdEeyInphUKJZxtQ")]
    [DisplayName("Technique")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tchnq")]
    #endif
    [IsoXmlTag("Tchnq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RiskReductionService1Code Technique { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RiskReductionService1Code Technique { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskReductionService1Code Technique { get; init; } 
    #else
    public RiskReductionService1Code Technique { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the post trade risk reduction service provider.
    /// </summary>
    [IsoId("_1HX7s_bdEeyInphUKJZxtQ")]
    [DisplayName("Service Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcPrvdr")]
    #endif
    [IsoXmlTag("SvcPrvdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? ServiceProvider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? ServiceProvider { get; init; } 
    #else
    public OrganisationIdentification15Choice_? ServiceProvider { get; set; } 
    #endif
    
    
    #nullable disable
    
}
