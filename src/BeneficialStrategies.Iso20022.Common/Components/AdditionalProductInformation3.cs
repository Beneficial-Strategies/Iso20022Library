// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional Product Information3.
/// </summary>
[IsoId("_Zy-BASY2Ee6m8LTtAzU6hA")]
[DisplayName("Additional Product Information3")]
public partial record AdditionalProductInformation3
{
    #nullable enable

    /// <summary>
    /// Financial Instrument Transaction Costs Ex Ante UK.
    /// </summary>
    [DisplayName("Financial Instrument Transaction Costs Ex Ante UK")]
    [IsoXmlTag("FinInstrmTxCostsExAnteUK")]
    public IsoPercentageRate? FinancialInstrumentTransactionCostsExAnteUK { get; init; } 

    /// <summary>
    /// Financial Instrument Transaction Costs Ex Post UK.
    /// </summary>
    [DisplayName("Financial Instrument Transaction Costs Ex Post UK")]
    [IsoXmlTag("FinInstrmTxCostsExPstUK")]
    public IsoPercentageRate? FinancialInstrumentTransactionCostsExPostUK { get; init; } 

    
    #nullable disable
    
}
