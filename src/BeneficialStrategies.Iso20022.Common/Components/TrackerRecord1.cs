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
/// Specifies the agent specific tracking system information of a payment transaction.
/// </summary>
[IsoId("_2db_MIW5EeiDBOVr6AJAFA")]
[DisplayName("Tracker Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerRecord1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerRecord1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerRecord1( BranchAndFinancialInstitutionIdentification6 reqAgent )
    {
        Agent = reqAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of an agent in the tracker.
    /// </summary>
    [IsoId("_9652UIW5EeiDBOVr6AJAFA")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 Agent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 Agent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_FxOSUIW6EeiDBOVr6AJAFA")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_ZQS6IYW6EeiDBOVr6AJAFA")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ChargesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_m7PxwYW7EeiDBOVr6AJAFA")]
    [DisplayName("Exchange Rate Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateData")]
    #endif
    [IsoXmlTag("XchgRateData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange13? ExchangeRateData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange13? ExchangeRateData { get; init; } 
    #else
    public CurrencyExchange13? ExchangeRateData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
