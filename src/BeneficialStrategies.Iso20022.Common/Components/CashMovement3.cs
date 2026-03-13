// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash movement.
/// </summary>
[IsoId("_UI00l9p-Ed-ak6NoX_4Aeg_-1613745533")]
[DisplayName("Cash Movement")]
public partial record CashMovement3
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the posting.
    /// </summary>
    [IsoId("_UI00mNp-Ed-ak6NoX_4Aeg_1883309713")]
    [DisplayName("Posting Date Time")]
    [IsoXmlTag("PstngDtTm")]
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    
    /// <summary>
    /// Value date.
    /// </summary>
    [IsoId("_UI00mdp-Ed-ak6NoX_4Aeg_-799199475")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Cash amount that is posted.
    /// </summary>
    [IsoId("_UI00mtp-Ed-ak6NoX_4Aeg_-635737359")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UI00m9p-Ed-ak6NoX_4Aeg_-1623608416")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CashAccount18> AccountDetails { get; init; } = [];
    
    
    #nullable disable
    
}
