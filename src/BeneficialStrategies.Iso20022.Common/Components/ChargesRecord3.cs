// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
[IsoId("_9RGSN249EeiU9cctagi5ow")]
[DisplayName("Charges Record")]
public partial record ChargesRecord3
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_9bYPkW49EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_9bYPk249EeiU9cctagi5ow")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the charge should be included in the amount or is added as pre-advice.
    /// </summary>
    [IsoId("_9bYPlW49EeiU9cctagi5ow")]
    [DisplayName("Charge Included Indicator")]
    [IsoXmlTag("ChrgInclInd")]
    [IsoSimpleType(IsoSimpleType.ChargeIncludedIndicator)]
    public IsoChargeIncludedIndicator? ChargeIncludedIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_9bYPl249EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_9bYPmW49EeiU9cctagi5ow")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_9bYPm249EeiU9cctagi5ow")]
    [DisplayName("Bearer")]
    [IsoXmlTag("Br")]
    public ChargeBearerType1Code? Bearer { get; init; } 
    
    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_9bYPnW49EeiU9cctagi5ow")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification6? Agent { get; init; } 
    
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_9bYPn249EeiU9cctagi5ow")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; } 
    
    
    #nullable disable
    
}
