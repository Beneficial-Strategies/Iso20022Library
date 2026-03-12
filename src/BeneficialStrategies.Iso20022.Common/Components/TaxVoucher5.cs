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
[IsoId("_sk06k83wEee5nJBZsW8MFQ")]
[DisplayName("Tax Voucher")]
public partial record TaxVoucher5
{
    #nullable enable
    
    /// <summary>
    /// Unique reference for the tax voucher required by the relevant tax authorities to ensure that any claim relating to this particular tax voucher cannot be duplicated.
    /// </summary>
    [IsoId("_sk06lc3wEee5nJBZsW8MFQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    
    /// <summary>
    /// Date on which a dividend reinvestment purchase was completed. If there is only one bargain involved, the time it was struck needs to be included.
    /// </summary>
    [IsoId("_sk06nc3wEee5nJBZsW8MFQ")]
    [DisplayName("Bargain Date")]
    [IsoXmlTag("BrgnDt")]
    public DateAndDateTime2Choice_? BargainDate { get; init; } 
    
    /// <summary>
    /// Settlement date of the dividend reinvestment purchase transaction.
    /// </summary>
    [IsoId("_sk06pc3wEee5nJBZsW8MFQ")]
    [DisplayName("Bargain Settlement Date")]
    [IsoXmlTag("BrgnSttlmDt")]
    public DateAndDateTime2Choice_? BargainSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
