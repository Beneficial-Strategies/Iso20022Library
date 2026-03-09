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
/// Owner and account number of the guarantee fund.
/// </summary>
[IsoId("__ATdACchEeaBPexHR4QTEw")]
[DisplayName("Guarantee Fund Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GuaranteeFundInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GuaranteeFundInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GuaranteeFundInformation1( CashAccount24 reqGuaranteeFundAccount,FinancialInstitutionIdentification9 reqGuaranteeFundAccountOwner )
    {
        GuaranteeFundAccount = reqGuaranteeFundAccount;
        GuaranteeFundAccountOwner = reqGuaranteeFundAccountOwner;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Guarantee fund account identifier.
    /// </summary>
    [IsoId("_iCd_QCciEeaBPexHR4QTEw")]
    [DisplayName("Guarantee Fund Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntFndAcct")]
    #endif
    [IsoXmlTag("GrntFndAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount24 GuaranteeFundAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount24 GuaranteeFundAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24 GuaranteeFundAccount { get; init; } 
    #else
    public CashAccount24 GuaranteeFundAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Owner identification of the guarantee fund.
    /// </summary>
    [IsoId("_p7GvcCciEeaBPexHR4QTEw")]
    [DisplayName("Guarantee Fund Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntFndAcctOwnr")]
    #endif
    [IsoXmlTag("GrntFndAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification9 GuaranteeFundAccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification9 GuaranteeFundAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification9 GuaranteeFundAccountOwner { get; init; } 
    #else
    public FinancialInstitutionIdentification9 GuaranteeFundAccountOwner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
