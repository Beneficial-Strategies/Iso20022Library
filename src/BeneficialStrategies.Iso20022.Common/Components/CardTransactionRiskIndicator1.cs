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
/// Indicates to the issuer the level of risk of the transaction.
/// </summary>
[IsoId("_lnDF4HsKEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Risk Indicator")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionRiskIndicator1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionRiskIndicator1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionRiskIndicator1( System.UInt64 reqLevel )
    {
        Level = reqLevel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason to indicate a certain level of risk for the transaction.
    /// </summary>
    [IsoId("_BJYHkHsNEeSR68OJvMfxJQ")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardTransactionRiskReason1Code? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionRiskReason1Code? Reason { get; init; } 
    #else
    public CardTransactionRiskReason1Code? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Level of risk, from 1 to 99.
    /// </summary>
    [IsoId("_NUeygHsNEeSR68OJvMfxJQ")]
    [DisplayName("Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lvl")]
    #endif
    [IsoXmlTag("Lvl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Level { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Level { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Level { get; init; } 
    #else
    public System.UInt64 Level { get; set; } 
    #endif
    
    /// <summary>
    /// Recommended action for the issuer.
    /// </summary>
    [IsoId("_4l1jwHsNEeSR68OJvMfxJQ")]
    [DisplayName("Recommended Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcmmnddActn")]
    #endif
    [IsoXmlTag("RcmmnddActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionType4Code? RecommendedAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionType4Code? RecommendedAction { get; init; } 
    #else
    public ActionType4Code? RecommendedAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
