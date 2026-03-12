// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the charges related to the payment transaction.
/// </summary>
[IsoId("_RudD6tp-Ed-ak6NoX_4Aeg_-1792074809")]
[DisplayName("Charges Information")]
public partial record ChargesInformation3
{
    #nullable enable
    
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    [IsoId("_RumN0Np-Ed-ak6NoX_4Aeg_1334590365")]
    [DisplayName("Total Charges And Tax Amount")]
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    public CurrencyAndAmount? TotalChargesAndTaxAmount { get; init; } 
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_RumN0dp-Ed-ak6NoX_4Aeg_-1792074526")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Identifies the type of charge.
    /// </summary>
    [IsoId("_RumN0tp-Ed-ak6NoX_4Aeg_-808524662")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeTypeChoice_? Type { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RumN09p-Ed-ak6NoX_4Aeg_-808524507")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_RumN1Np-Ed-ak6NoX_4Aeg_-47544167")]
    [DisplayName("Bearer")]
    [IsoXmlTag("Br")]
    public ChargeBearerType1Code? Bearer { get; init; } 
    
    /// <summary>
    /// Party that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_RumN1dp-Ed-ak6NoX_4Aeg_-1792074422")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public BranchAndFinancialInstitutionIdentification3? Party { get; init; } 
    
    /// <summary>
    /// Specifies tax details applied to charges.
    /// </summary>
    [IsoId("_RumN1tp-Ed-ak6NoX_4Aeg_896295378")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges1? Tax { get; init; } 
    
    
    #nullable disable
    
}
