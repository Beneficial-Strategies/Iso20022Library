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
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
/// </summary>
[IsoId("_RUSFwKprEeamNLogr5TkIQ")]
[DisplayName("End Of Day Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EndOfDayRequirement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EndOfDayRequirement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EndOfDayRequirement2( InitialMarginRequirement1 reqInitialMarginRequirements,AmountAndDirection102 reqVariationMarginRequirements,GenericIdentification165 reqMarginAccountIdentification )
    {
        InitialMarginRequirements = reqInitialMarginRequirements;
        VariationMarginRequirements = reqVariationMarginRequirements;
        MarginAccountIdentification = reqMarginAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Liability and assets that arise for a clearing member with respect to a central counterparty.
    /// </summary>
    [IsoId("_c5B7UKprEeamNLogr5TkIQ")]
    [DisplayName("Initial Margin Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRqrmnts")]
    #endif
    [IsoXmlTag("InitlMrgnRqrmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InitialMarginRequirement1 InitialMarginRequirements { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InitialMarginRequirement1 InitialMarginRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InitialMarginRequirement1 InitialMarginRequirements { get; init; } 
    #else
    public InitialMarginRequirement1 InitialMarginRequirements { get; set; } 
    #endif
    
    /// <summary>
    /// Total change in the mark-to-market value of the margin account from the previous day, net of changes in mark-to-market relating to the entry or exit of derivative positions not entered into at zero mark-to-market (such as option premiums and upsettled upfront fees). Indicates whether the variation margin is paid to clearing members.
    /// </summary>
    [IsoId("_lUoOoKprEeamNLogr5TkIQ")]
    [DisplayName("Variation Margin Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRqrmnts")]
    #endif
    [IsoXmlTag("VartnMrgnRqrmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 VariationMarginRequirements { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 VariationMarginRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 VariationMarginRequirements { get; init; } 
    #else
    public AmountAndDirection102 VariationMarginRequirements { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of account used to calculate margin requirements. Usage: In the context of a central counterparty, if reported at the client level (expected for gross omnibus and individual segregated accounts), will report the Client ID in the Internal ID field and choose &apos;ClientID&apos; for the CCP Participant ID Type. If reported at the clearing member account level will report the account ID in the Internal ID field and choose &apos;AccountID&apos; for the CCP Participant ID Type.
    /// </summary>
    [IsoId("_lQt8gPnfEeaQh_7a05rSJQ")]
    [DisplayName("Margin Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnAcctId")]
    #endif
    [IsoXmlTag("MrgnAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 MarginAccountIdentification { get; init; } 
    #else
    public GenericIdentification165 MarginAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
