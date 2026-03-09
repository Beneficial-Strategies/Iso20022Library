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
/// Specifies the settlement failure reason as defined in the relevant regulation.
/// </summary>
[IsoId("_MQiA0TOmEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Daily Failure Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDailyFailureReason3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDailyFailureReason3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDailyFailureReason3( SettlementTotalData1Choice_ reqFailedSecurities,SettlementTotalData1Choice_ reqFailedCash )
    {
        FailedSecurities = reqFailedSecurities;
        FailedCash = reqFailedCash;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Fails due to lack of securities.
    /// </summary>
    [IsoId("_MRbYsTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Failed Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaildScties")]
    #endif
    [IsoXmlTag("FaildScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ FailedSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ FailedSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ FailedSecurities { get; init; } 
    #else
    public SettlementTotalData1Choice_ FailedSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Fails due to lack of cash.
    /// </summary>
    [IsoId("_MRbYszOmEeqX8uoQQ3KffQ")]
    [DisplayName("Failed Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaildCsh")]
    #endif
    [IsoXmlTag("FaildCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ FailedCash { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ FailedCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ FailedCash { get; init; } 
    #else
    public SettlementTotalData1Choice_ FailedCash { get; set; } 
    #endif
    
    
    #nullable disable
    
}
