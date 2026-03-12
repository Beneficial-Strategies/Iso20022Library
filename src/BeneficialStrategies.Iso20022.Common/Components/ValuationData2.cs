// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of data which contains the link to the opening of the non deliverable trade and supplementary information on its valuation.
/// </summary>
[IsoId("_TIKBxNp-Ed-ak6NoX_4Aeg_-1153647347")]
[DisplayName("Valuation Data")]
public partial record ValuationData2
{
    #nullable enable
    
    /// <summary>
    /// Reference to the latest trade identification of the NDF opening trade.
    /// </summary>
    [IsoId("_TIKBxdp-Ed-ak6NoX_4Aeg_-1153647330")]
    [DisplayName("Valuation Reference")]
    [IsoXmlTag("ValtnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ValuationReference { get; init; } 
    
    /// <summary>
    /// Specifies the currency in which the non deliverable trade has to be settled ie the deliverable currency.
    /// </summary>
    [IsoId("_TIKBxtp-Ed-ak6NoX_4Aeg_-1153647004")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Free format text that may contain information on the valuation such as the currency, the place, the time or the source of the rate.
    /// </summary>
    [IsoId("_TIKBx9p-Ed-ak6NoX_4Aeg_-1153647295")]
    [DisplayName("Additional Valuation Information")]
    [IsoXmlTag("AddtlValtnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalValuationInformation { get; init; } 
    
    /// <summary>
    /// Party through which the settlement will take place. It may contain the BIC of a central settlement system eg CLSBUS33.
    /// </summary>
    [IsoId("_TIKByNp-Ed-ak6NoX_4Aeg_-1153647029")]
    [DisplayName("Settlement Party")]
    [IsoXmlTag("SttlmPty")]
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    
    
    #nullable disable
    
}
