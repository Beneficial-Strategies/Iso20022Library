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
[IsoId("_EzMu4ZELEem-9Y6mq5ZH3Q")]
[DisplayName("Tax")]
public partial record Tax38
{
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_FGYwo5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Basis used to determine the capital gain or loss.
    /// </summary>
    [IsoId("_FGYwpZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxBasis1Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_FGYwp5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_FGYwqZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_FGYwq5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    
    /// <summary>
    /// Reason for the tax exemption.
    /// </summary>
    [IsoId("_FGYwrZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; } 
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_FGYwr5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_FGYwsZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation11? TaxCalculationDetails { get; init; } 
    
    
    #nullable disable
    
}
