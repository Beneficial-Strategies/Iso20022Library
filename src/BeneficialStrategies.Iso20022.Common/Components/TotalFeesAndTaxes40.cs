// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_VJEXMDh2EeamLZQeccJa7w")]
[DisplayName("Total Fees And Taxes")]
public partial record TotalFeesAndTaxes40
{
    #nullable enable
    
    /// <summary>
    /// Total amount of overhead applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_k2yNQTh2EeamLZQeccJa7w")]
    [DisplayName("Total Overhead Applied")]
    [IsoXmlTag("TtlOvrhdApld")]
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; } 
    
    /// <summary>
    /// Total amount of fees (charge/commissions) applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_5R60sTh2EeamLZQeccJa7w")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; } 
    
    /// <summary>
    /// Total amount of taxes applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_-H0zsTh2EeamLZQeccJa7w")]
    [DisplayName("Total Taxes")]
    [IsoXmlTag("TtlTaxs")]
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_Bufe0XTEEea79aegl3yVYg")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_uoKLQDh3EeamLZQeccJa7w")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public Fee2? IndividualFee { get; init; } 
    
    /// <summary>
    /// Individual tax.
    /// </summary>
    [IsoId("_0eXCQDh6EeaH-93K5JKmzw")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public Tax31? IndividualTax { get; init; } 
    
    
    #nullable disable
    
}
