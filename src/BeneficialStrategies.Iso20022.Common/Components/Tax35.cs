// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_-FSq8W1bEeiqaPNRWUnGNA")]
[DisplayName("Tax")]
public partial record Tax35
{
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_-WZpE21bEeiqaPNRWUnGNA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3Choice_ Type { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_-WZpFW1bEeiqaPNRWUnGNA")]
    [DisplayName("Applied Amount")]
    [IsoXmlTag("ApldAmt")]
    public required ActiveCurrencyAndAmount AppliedAmount { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_-WZpF21bEeiqaPNRWUnGNA")]
    [DisplayName("Applied Rate")]
    [IsoXmlTag("ApldRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AppliedRate { get; init; } 
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_-WZpGW1bEeiqaPNRWUnGNA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_-WZpG21bEeiqaPNRWUnGNA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_-WZpHW1bEeiqaPNRWUnGNA")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation10? TaxCalculationDetails { get; init; } 
    
    
    #nullable disable
    
}
