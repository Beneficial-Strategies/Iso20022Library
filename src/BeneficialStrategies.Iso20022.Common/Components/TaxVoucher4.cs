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
[IsoId("_7HbzEbQZEeeKRKrD60ELBQ")]
[DisplayName("Tax Voucher")]
public partial record TaxVoucher4
{
    #nullable enable
    
    /// <summary>
    /// Unique reference for the tax voucher required by the relevant tax authorities to ensure that any claim relating to this particular tax voucher cannot be duplicated.
    /// </summary>
    [IsoId("_7YiKIbQZEeeKRKrD60ELBQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date on which a dividend reinvestment purchase was completed. If there is only one bargain involved, the time it was struck needs to be included.
    /// </summary>
    [IsoId("_7YiKKbQZEeeKRKrD60ELBQ")]
    [DisplayName("Bargain Date")]
    [IsoXmlTag("BrgnDt")]
    public DateAndDateTime2Choice_? BargainDate { get; init; } 
    
    /// <summary>
    /// Settlement date of the dividend reinvestment purchase transaction.
    /// </summary>
    [IsoId("_7YiKMbQZEeeKRKrD60ELBQ")]
    [DisplayName("Bargain Settlement Date")]
    [IsoXmlTag("BrgnSttlmDt")]
    public DateAndDateTime2Choice_? BargainSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
