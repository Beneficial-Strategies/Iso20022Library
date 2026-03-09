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
/// Provides information about the entitlement.
/// </summary>
[IsoId("_UJRggtp-Ed-ak6NoX_4Aeg_-1393093293")]
[DisplayName("Entitlement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Entitlement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Entitlement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Entitlement1( System.String reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_UJRgg9p-Ed-ak6NoX_4Aeg_-505589087")]
    [DisplayName("Account Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrId")]
    #endif
    [IsoXmlTag("AcctOwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Idenfitication of the account.
    /// </summary>
    [IsoId("_UJRghNp-Ed-ak6NoX_4Aeg_-505589086")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountIdentification { get; init; } 
    #else
    public System.String AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the securities distribution.
    /// </summary>
    [IsoId("_UJRghdp-Ed-ak6NoX_4Aeg_1936794544")]
    [DisplayName("Securities Distribution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesDstrbtnDtls")]
    #endif
    [IsoXmlTag("SctiesDstrbtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesEntitlement1? SecuritiesDistributionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesEntitlement1? SecuritiesDistributionDetails { get; init; } 
    #else
    public SecuritiesEntitlement1? SecuritiesDistributionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash distribution.
    /// </summary>
    [IsoId("_UJRghtp-Ed-ak6NoX_4Aeg_1939563150")]
    [DisplayName("Cash Distribution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshDstrbtnDtls")]
    #endif
    [IsoXmlTag("CshDstrbtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashEntitlement1? CashDistributionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashEntitlement1? CashDistributionDetails { get; init; } 
    #else
    public CashEntitlement1? CashDistributionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
