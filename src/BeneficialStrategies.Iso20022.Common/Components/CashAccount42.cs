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
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_fFDdVdcZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount42
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_fGg149cZEeqRFcf2R4bPBw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    [IsoId("_fGg15dcZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountType2Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountType2Choice_? Type { get; init; } 
    #else
    public CashAccountType2Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency of the cash account.
    /// </summary>
    [IsoId("_fGg159cZEeqRFcf2R4bPBw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an alternate assumed name for the identification of the account. 
    /// </summary>
    [IsoId("_fGg16dcZEeqRFcf2R4bPBw")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProxyAccountIdentification1? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyAccountIdentification1? Proxy { get; init; } 
    #else
    public ProxyAccountIdentification1? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount value applied to or by a participant versus a set of counterparts. The multilateral system is taken into account by the transaction administrator to contain the risk in the system.|With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for whom no bilateral limit was set.
    /// </summary>
    [IsoId("_fGg169cZEeqRFcf2R4bPBw")]
    [DisplayName("Current Multilateral Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurMulLmt")]
    #endif
    [IsoXmlTag("CurMulLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Limit5? CurrentMultilateralLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Limit5? CurrentMultilateralLimit { get; init; } 
    #else
    public Limit5? CurrentMultilateralLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_fGg17dcZEeqRFcf2R4bPBw")]
    [DisplayName("Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ownr")]
    #endif
    [IsoXmlTag("Ownr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Owner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Owner { get; init; } 
    #else
    public PartyIdentification135? Owner { get; set; } 
    #endif
    
    /// <summary>
    /// Servicer of the account which is being queried.
    /// </summary>
    [IsoId("_fGg179cZEeqRFcf2R4bPBw")]
    [DisplayName("Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svcr")]
    #endif
    [IsoXmlTag("Svcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; set; } 
    #endif
    
    /// <summary>
    /// Balance is calculated with regard to many members in the system.
    /// </summary>
    [IsoId("_fGg18dcZEeqRFcf2R4bPBw")]
    [DisplayName("Multilateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MulBal")]
    #endif
    [IsoXmlTag("MulBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalance13? MultilateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalance13? MultilateralBalance { get; init; } 
    #else
    public CashBalance13? MultilateralBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Limit fixed by a party A with regard to a specific counterparty B and corresponding to the maximum amount of traffic that party A may send to party B. The bilateral limit can be expressed as a debit limit or a credit limit. |With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// </summary>
    [IsoId("_fGg189cZEeqRFcf2R4bPBw")]
    [DisplayName("Current Bilateral Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurBilLmt")]
    #endif
    [IsoXmlTag("CurBilLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BilateralLimit3? CurrentBilateralLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BilateralLimit3? CurrentBilateralLimit { get; init; } 
    #else
    public BilateralLimit3? CurrentBilateralLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction given by a party that has explicit authority to instruct a debit on the account, that is either the debtor or originating party, to the debtor agent, to process liquidity transfers at specified intervals during an implicit or explicit period of time. A standing order is given once and is valid for an open or closed period of time.
    /// </summary>
    [IsoId("_fGg19dcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdr")]
    #endif
    [IsoXmlTag("StgOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingOrder9? StandingOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrder9? StandingOrder { get; init; } 
    #else
    public StandingOrder9? StandingOrder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
