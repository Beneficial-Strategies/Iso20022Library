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
/// Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.
/// </summary>
[IsoId("_UvqKAKp3EeamNLogr5TkIQ")]
[DisplayName("Default Fund Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DefaultFundRequirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DefaultFundRequirement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DefaultFundRequirement1( GenericIdentification165 reqClearingMemberIdentification,ActiveCurrencyAndAmount reqAmount )
    {
        ClearingMemberIdentification = reqClearingMemberIdentification;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the clearing member.
    /// </summary>
    [IsoId("_KvDyUKp4EeamNLogr5TkIQ")]
    [DisplayName("Clearing Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmbId")]
    #endif
    [IsoXmlTag("ClrMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 ClearingMemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 ClearingMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 ClearingMemberIdentification { get; init; } 
    #else
    public GenericIdentification165 ClearingMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Central counterparty&apos;s identification of the service where default fund contributions are made at the service level.
    /// </summary>
    [IsoId("_T0Xt0cBtEeak3I7j2hsibw")]
    [DisplayName("Service Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcId")]
    #endif
    [IsoXmlTag("SvcId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceIdentification { get; init; } 
    #else
    public System.String? ServiceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing member&apos;s pre-funded default fund requirement for the default fund at the central counterparty.
    /// </summary>
    [IsoId("_T0Xt0sBtEeak3I7j2hsibw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
