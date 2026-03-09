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
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_HfN7YU_lEeaB8-OWTiMVrQ")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount64
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
    [IsoId("_H3w-Q0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_H3w-RU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsgnt")]
    #endif
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Designation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Designation { get; init; } 
    #else
    public System.String? Designation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal form of the fund, for example, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    [IsoId("_H3w-R0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Fund Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndTp")]
    #endif
    [IsoXmlTag("FndTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FundType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundType { get; init; } 
    #else
    public System.String? FundType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_H3w-SU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Fund Family Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndFmlyNm")]
    #endif
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FundFamilyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundFamilyName { get; init; } 
    #else
    public System.String? FundFamilyName { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_H3w-S0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDtls")]
    #endif
    [IsoXmlTag("SctyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument55? SecurityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument55? SecurityDetails { get; init; } 
    #else
    public FinancialInstrument55? SecurityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account.
    /// </summary>
    [IsoId("_H3w-TU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountOwner2Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountOwner2Choice_? AccountOwner { get; init; } 
    #else
    public AccountOwner2Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_H3w-T0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmy")]
    #endif
    [IsoXmlTag("Intrmy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary33> Intermediary { get; init; } = new ValueList<Intermediary33>(){};
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_H3w-UU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification70Choice_? AccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
