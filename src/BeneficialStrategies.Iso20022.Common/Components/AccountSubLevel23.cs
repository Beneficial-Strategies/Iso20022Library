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
/// Provides shareholdings information at account sub level.
/// </summary>
[IsoId("_M0-jp_NyEeqRfth943bvEA")]
[DisplayName("Account Sub Level")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSubLevel23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountSubLevel23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSubLevel23( PartyIdentification243 reqAccountHolder )
    {
        AccountHolder = reqAccountHolder;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained. Account serviced by the responding intermediary for an account holder.
    /// </summary>
    [IsoId("_NH3qcfNyEeqRfth943bvEA")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SafekeepingAccount { get; init; } 
    #else
    public System.String? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_NH3qefNyEeqRfth943bvEA")]
    [DisplayName("Account Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctHldr")]
    #endif
    [IsoXmlTag("AcctHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification243 AccountHolder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification243 AccountHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification243 AccountHolder { get; init; } 
    #else
    public PartyIdentification243 AccountHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed shareholding balance information for an account.
    /// </summary>
    [IsoId("_NH3qe_NyEeqRfth943bvEA")]
    [DisplayName("Shareholding Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldgBal")]
    #endif
    [IsoXmlTag("ShrhldgBal")]
    public ValueList<ShareholdingBalance1> ShareholdingBalance { get; init; } = new ValueList<ShareholdingBalance1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _NH3qe_NyEeqRfth943bvEA
    
    
    #nullable disable
    
}
