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
[IsoId("_XiLKcW1bEeiqaPNRWUnGNA")]
[DisplayName("Total Fees And Taxes")]
public partial record TotalFeesAndTaxes41
{
    #nullable enable
    
    /// <summary>
    /// Total amount of overhead applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_XzIXlW1bEeiqaPNRWUnGNA")]
    [DisplayName("Total Overhead Applied")]
    [IsoXmlTag("TtlOvrhdApld")]
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; } 
    
    /// <summary>
    /// Total amount of fees (charge/commissions) applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_XzIXl21bEeiqaPNRWUnGNA")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; } 
    
    /// <summary>
    /// Total amount of taxes applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_XzIXmW1bEeiqaPNRWUnGNA")]
    [DisplayName("Total Taxes")]
    [IsoXmlTag("TtlTaxs")]
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_XzIXm21bEeiqaPNRWUnGNA")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_XzIXnW1bEeiqaPNRWUnGNA")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public Fee5? IndividualFee { get; init; } 
    
    /// <summary>
    /// Individual tax.
    /// </summary>
    [IsoId("_XzIXn21bEeiqaPNRWUnGNA")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public Tax35? IndividualTax { get; init; } 
    
    
    #nullable disable
    
}
