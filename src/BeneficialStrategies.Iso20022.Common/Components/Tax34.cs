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
[IsoId("_0l9lsYjNEeeiYZ2e3mpBRA")]
[DisplayName("Tax")]
public partial record Tax34
{
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_02VkA4jNEeeiYZ2e3mpBRA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Basis used to determine the capital gain or loss.
    /// </summary>
    [IsoId("_vidaIYjOEeeiYZ2e3mpBRA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxBasis1Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_-orn0YjNEeeiYZ2e3mpBRA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_02VkB4jNEeeiYZ2e3mpBRA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_02VkCYjNEeeiYZ2e3mpBRA")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    
    /// <summary>
    /// Reason for the tax exemption.
    /// </summary>
    [IsoId("_02VkC4jNEeeiYZ2e3mpBRA")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; } 
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_02VkDYjNEeeiYZ2e3mpBRA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification113? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_02VkD4jNEeeiYZ2e3mpBRA")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation11? TaxCalculationDetails { get; init; } 
    
    
    #nullable disable
    
}
