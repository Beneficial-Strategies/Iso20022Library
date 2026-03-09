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
/// Specifies tax vouchers in the framework of a corporate action event.
/// </summary>
[IsoId("_XIdOedp-Ed-ak6NoX_4Aeg_913335688")]
[DisplayName("Tax Voucher")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxVoucher3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxVoucher3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxVoucher3( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference for the tax voucher required by the relevant tax authorities to ensure that any claim relating to this particular tax voucher cannot be duplicated.
    /// </summary>
    [IsoId("_XIdOetp-Ed-ak6NoX_4Aeg_-1080809018")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a dividend reinvestment purchase was completed. If there is only one bargain involved, the time it was struck needs to be included.
    /// </summary>
    [IsoId("_XIdOe9p-Ed-ak6NoX_4Aeg_1398132244")]
    [DisplayName("Bargain Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrgnDt")]
    #endif
    [IsoXmlTag("BrgnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? BargainDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? BargainDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? BargainDate { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement date of the dividend reinvestment purchase transaction.
    /// </summary>
    [IsoId("_XIm_cNp-Ed-ak6NoX_4Aeg_-1593084815")]
    [DisplayName("Bargain Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrgnSttlmDt")]
    #endif
    [IsoXmlTag("BrgnSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? BargainSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? BargainSettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? BargainSettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
