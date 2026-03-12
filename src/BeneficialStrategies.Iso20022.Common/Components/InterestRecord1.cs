// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_txS1EVkyEeGeoaLUQk__nA_677183117")]
[DisplayName("Interest Record")]
public partial record InterestRecord1
{
    #nullable enable
    
    /// <summary>
    /// Amount of interest included in the entry amount.
    /// </summary>
    [IsoId("_txS1ElkyEeGeoaLUQk__nA_563344051")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest amount included in the entry is credit or debit amount.
    /// Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_txS1E1kyEeGeoaLUQk__nA_-433728302")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_txcmEFkyEeGeoaLUQk__nA_-1353761954")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_txcmEVkyEeGeoaLUQk__nA_332227948")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate3? Rate { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_txcmElkyEeGeoaLUQk__nA_-664844405")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_txcmE1kyEeGeoaLUQk__nA_-1661916758")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_txcmFFkyEeGeoaLUQk__nA_205600801")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; } 
    
    
    #nullable disable
    
}
