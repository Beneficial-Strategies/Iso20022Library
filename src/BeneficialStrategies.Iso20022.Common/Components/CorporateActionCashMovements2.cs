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
/// Provides information about the cash movement resulting from the election instruction.
/// </summary>
[IsoId("_UI00nNp-Ed-ak6NoX_4Aeg_-1357600195")]
[DisplayName("Corporate Action Cash Movements")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionCashMovements2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionCashMovements2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionCashMovements2( ActiveCurrencyAndAmount reqPostingAmount )
    {
        PostingAmount = reqPostingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Posting identification of the cash movement.
    /// </summary>
    [IsoId("_UI00ndp-Ed-ak6NoX_4Aeg_-178406164")]
    [DisplayName("Posting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngId")]
    #endif
    [IsoXmlTag("PstngId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PostingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostingIdentification { get; init; } 
    #else
    public System.String? PostingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Posting date of the cash movement.
    /// </summary>
    [IsoId("_UI-lkNp-Ed-ak6NoX_4Aeg_-2039409118")]
    [DisplayName("Posting Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDtTm")]
    #endif
    [IsoXmlTag("PstngDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PostingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Amount posted as a result of the cash movement.
    /// </summary>
    [IsoId("_UI-lkdp-Ed-ak6NoX_4Aeg_-447933901")]
    [DisplayName("Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngAmt")]
    #endif
    [IsoXmlTag("PstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PostingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount PostingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the account which is debited/credited as a result of the movement.
    /// </summary>
    [IsoId("_UI-lktp-Ed-ak6NoX_4Aeg_1235283367")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CashAccount19> AccountDetails { get; init; } = new ValueList<CashAccount19>(){};
    
    
    #nullable disable
    
}
