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
/// Provides account and balance information.
/// </summary>
[IsoId("_QSzlR9p-Ed-ak6NoX_4Aeg_237043718")]
[DisplayName("Account And Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountAndBalance4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountAndBalance4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountAndBalance4( System.String reqSafekeepingAccount,BalanceFormat1Choice_ reqConfirmedBalance )
    {
        SafekeepingAccount = reqSafekeepingAccount;
        ConfirmedBalance = reqConfirmedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QSzlSNp-Ed-ak6NoX_4Aeg_123204652")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SafekeepingAccount { get; init; } 
    #else
    public System.String SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_QSzlSdp-Ed-ak6NoX_4Aeg_-1069395630")]
    [DisplayName("Confirmed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdBal")]
    #endif
    [IsoXmlTag("ConfdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_ ConfirmedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
