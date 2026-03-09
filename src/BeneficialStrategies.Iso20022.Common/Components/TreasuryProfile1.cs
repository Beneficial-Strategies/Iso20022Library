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
/// Treasury trading profile.
/// </summary>
[IsoId("_BzjroCDSEeWCLu74WLgP4w")]
[DisplayName("Treasury Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TreasuryProfile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TreasuryProfile1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TreasuryProfile1( System.DateOnly reqDate,PartyRole5Choice_ reqTraderType,System.Decimal reqRate )
    {
        Date = reqDate;
        TraderType = reqTraderType;
        Rate = reqRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Execution date of treasury bond trade.
    /// </summary>
    [IsoId("_IENKUCDSEeWCLu74WLgP4w")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    /// <summary>
    /// Type of party that performs trading operations, for example, investor or custodian.
    /// </summary>
    [IsoId("_KVaX8CDSEeWCLu74WLgP4w")]
    [DisplayName("Trader Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradrTp")]
    #endif
    [IsoXmlTag("TradrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyRole5Choice_ TraderType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyRole5Choice_ TraderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyRole5Choice_ TraderType { get; init; } 
    #else
    public PartyRole5Choice_ TraderType { get; set; } 
    #endif
    
    /// <summary>
    /// Tax rate.
    /// </summary>
    [IsoId("_79wgcCDSEeWCLu74WLgP4w")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
