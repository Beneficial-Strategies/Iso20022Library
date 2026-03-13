// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash movement resulting from the election instruction.
/// </summary>
[IsoId("_UI00nNp-Ed-ak6NoX_4Aeg_-1357600195")]
[DisplayName("Corporate Action Cash Movements")]
public partial record CorporateActionCashMovements2
{
    #nullable enable
    
    /// <summary>
    /// Posting identification of the cash movement.
    /// </summary>
    [IsoId("_UI00ndp-Ed-ak6NoX_4Aeg_-178406164")]
    [DisplayName("Posting Identification")]
    [IsoXmlTag("PstngId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PostingIdentification { get; init; } 
    
    /// <summary>
    /// Posting date of the cash movement.
    /// </summary>
    [IsoId("_UI-lkNp-Ed-ak6NoX_4Aeg_-2039409118")]
    [DisplayName("Posting Date Time")]
    [IsoXmlTag("PstngDtTm")]
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    
    /// <summary>
    /// Amount posted as a result of the cash movement.
    /// </summary>
    [IsoId("_UI-lkdp-Ed-ak6NoX_4Aeg_-447933901")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    
    /// <summary>
    /// Provides information about the account which is debited/credited as a result of the movement.
    /// </summary>
    [IsoId("_UI-lktp-Ed-ak6NoX_4Aeg_1235283367")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CashAccount19> AccountDetails { get; init; } = [];
    
    
    #nullable disable
    
}
