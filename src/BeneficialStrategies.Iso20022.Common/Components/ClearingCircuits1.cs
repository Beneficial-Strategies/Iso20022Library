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
/// Clearing circuits information.
/// </summary>
[IsoId("_dWs4gB9zEeapDZRA0Hb6ow")]
[DisplayName("Clearing Circuits")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingCircuits1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingCircuits1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingCircuits1( ClearingScheme1Choice_ reqClearingCircuit,System.String reqClaimLimitIndicator,System.String reqClearingSchemeShortName,System.String reqClearingSchemeLongName,System.String reqAllOrNothingIndicator,GuaranteeFunds1 reqGuaranteeFunds,CashAccount24 reqClearingAccount,FinancialInstitutionIdentification9 reqClearingAccountOwner )
    {
        ClearingCircuit = reqClearingCircuit;
        ClaimLimitIndicator = reqClaimLimitIndicator;
        ClearingSchemeShortName = reqClearingSchemeShortName;
        ClearingSchemeLongName = reqClearingSchemeLongName;
        AllOrNothingIndicator = reqAllOrNothingIndicator;
        GuaranteeFunds = reqGuaranteeFunds;
        ClearingAccount = reqClearingAccount;
        ClearingAccountOwner = reqClearingAccountOwner;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Clearing scheme used.
    /// </summary>
    [IsoId("_lHJ9EB9zEeapDZRA0Hb6ow")]
    [DisplayName("Clearing Circuit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCrct")]
    #endif
    [IsoXmlTag("ClrCrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClearingScheme1Choice_ ClearingCircuit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClearingScheme1Choice_ ClearingCircuit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingScheme1Choice_ ClearingCircuit { get; init; } 
    #else
    public ClearingScheme1Choice_ ClearingCircuit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the limits can be set for the external payment system.
    /// </summary>
    [IsoId("_s5xIUB90EeapDZRA0Hb6ow")]
    [DisplayName("Claim Limit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClmLmtInd")]
    #endif
    [IsoXmlTag("ClmLmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ClaimLimitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClaimLimitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClaimLimitIndicator { get; init; } 
    #else
    public System.String ClaimLimitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Short name of the clearing scheme.
    /// </summary>
    [IsoId("_3LyKsB90EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Scheme Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSchmeShrtNm")]
    #endif
    [IsoXmlTag("ClrSchmeShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax40Text ClearingSchemeShortName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClearingSchemeShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClearingSchemeShortName { get; init; } 
    #else
    public System.String ClearingSchemeShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Long name of the clearing scheme.
    /// </summary>
    [IsoId("_DkXQ8B91EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Scheme Long Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSchmeLngNm")]
    #endif
    [IsoXmlTag("ClrSchmeLngNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text ClearingSchemeLongName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClearingSchemeLongName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClearingSchemeLongName { get; init; } 
    #else
    public System.String ClearingSchemeLongName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether all or nothing rule is in effect.
    /// </summary>
    [IsoId("_i_ZUcB91EeapDZRA0Hb6ow")]
    [DisplayName("All Or Nothing Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOrNthgInd")]
    #endif
    [IsoXmlTag("AllOrNthgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AllOrNothingIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AllOrNothingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AllOrNothingIndicator { get; init; } 
    #else
    public System.String AllOrNothingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Guarantee funds details.
    /// </summary>
    [IsoId("_8zngcB91EeapDZRA0Hb6ow")]
    [DisplayName("Guarantee Funds")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntFnds")]
    #endif
    [IsoXmlTag("GrntFnds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GuaranteeFunds1 GuaranteeFunds { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GuaranteeFunds1 GuaranteeFunds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GuaranteeFunds1 GuaranteeFunds { get; init; } 
    #else
    public GuaranteeFunds1 GuaranteeFunds { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing account identifier.
    /// </summary>
    [IsoId("_UjoHEB94EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcct")]
    #endif
    [IsoXmlTag("ClrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount24 ClearingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount24 ClearingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24 ClearingAccount { get; init; } 
    #else
    public CashAccount24 ClearingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the clearing account owner.
    /// </summary>
    [IsoId("_fJw_UB94EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcctOwnr")]
    #endif
    [IsoXmlTag("ClrAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification9 ClearingAccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification9 ClearingAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification9 ClearingAccountOwner { get; init; } 
    #else
    public FinancialInstitutionIdentification9 ClearingAccountOwner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
