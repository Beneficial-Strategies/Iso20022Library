// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the tax amount(s) of tax record.
/// </summary>
[IsoId("_RwGCpNp-Ed-ak6NoX_4Aeg_-1186076323")]
[DisplayName("Tax Amount")]
public partial record TaxAmount1
{
    #nullable enable
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_RwGCpdp-Ed-ak6NoX_4Aeg_-1186076014")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Amount of money on which the tax is based.
    /// </summary>
    [IsoId("_RwGCptp-Ed-ak6NoX_4Aeg_-1186075922")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; } 
    
    /// <summary>
    /// Total amount that is the result of the calculation of the tax for the record.
    /// </summary>
    [IsoId("_RwGCp9p-Ed-ak6NoX_4Aeg_-1186075952")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide details on the tax period and amount.
    /// </summary>
    [IsoId("_RwPMkNp-Ed-ak6NoX_4Aeg_-515652974")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public TaxRecordDetails1? Details { get; init; } 
    
    
    #nullable disable
    
}
