// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Nature or use of the account.
/// </summary>
[IsoId("_T4SeN9p-Ed-ak6NoX_4Aeg_-1717865628")]
[DisplayName("Cash Account Type")]
public partial record CashAccountType2
{
    #nullable enable
    
    /// <summary>
    /// Account type, in a coded form.
    /// </summary>
    [IsoId("_T4SeONp-Ed-ak6NoX_4Aeg_-1686465493")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CashAccountType4Code Code { get; init; } 
    
    /// <summary>
    /// Nature or use of the account in a proprietary form.
    /// </summary>
    [IsoId("_T4SeOdp-Ed-ak6NoX_4Aeg_-1643987013")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Proprietary { get; init; } 
    
    
    #nullable disable
    
}
