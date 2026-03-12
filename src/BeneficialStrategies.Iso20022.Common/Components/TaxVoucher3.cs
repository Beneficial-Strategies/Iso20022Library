// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies tax vouchers in the framework of a corporate action event.
/// </summary>
[IsoId("_XIdOedp-Ed-ak6NoX_4Aeg_913335688")]
[DisplayName("Tax Voucher")]
public partial record TaxVoucher3
{
    #nullable enable
    
    /// <summary>
    /// Unique reference for the tax voucher required by the relevant tax authorities to ensure that any claim relating to this particular tax voucher cannot be duplicated.
    /// </summary>
    [IsoId("_XIdOetp-Ed-ak6NoX_4Aeg_-1080809018")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    
    /// <summary>
    /// Date on which a dividend reinvestment purchase was completed. If there is only one bargain involved, the time it was struck needs to be included.
    /// </summary>
    [IsoId("_XIdOe9p-Ed-ak6NoX_4Aeg_1398132244")]
    [DisplayName("Bargain Date")]
    [IsoXmlTag("BrgnDt")]
    public DateAndDateTimeChoice_? BargainDate { get; init; } 
    
    /// <summary>
    /// Settlement date of the dividend reinvestment purchase transaction.
    /// </summary>
    [IsoId("_XIm_cNp-Ed-ak6NoX_4Aeg_-1593084815")]
    [DisplayName("Bargain Settlement Date")]
    [IsoXmlTag("BrgnSttlmDt")]
    public DateAndDateTimeChoice_? BargainSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
