// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of parameters used to calculate the fixing rate to be applied to a non-deliverable agreement.
/// </summary>
[IsoId("_TIAQw9p-Ed-ak6NoX_4Aeg_1813124879")]
[DisplayName("Non Deliverable Forward Valuation Conditions")]
public partial record NonDeliverableForwardValuationConditions2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the currency in which the non deliverable trade has to be settled ie the deliverable currency.
    /// </summary>
    [IsoId("_TIAQxNp-Ed-ak6NoX_4Aeg_1813124956")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveOrHistoricCurrencyCode SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Date at which the rate used for calculating the net amount to be settled is observed.
    /// </summary>
    [IsoId("_TIAQxdp-Ed-ak6NoX_4Aeg_1813124914")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValuationDate { get; init; } 
    
    /// <summary>
    /// Free format text that may contain valuation information such as the place, the time or the source of the rate.
    /// </summary>
    [IsoId("_TIAQxtp-Ed-ak6NoX_4Aeg_1813124939")]
    [DisplayName("Additional Valuation Information")]
    [IsoXmlTag("AddtlValtnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalValuationInformation { get; init; } 
    
    /// <summary>
    /// Party through which the settlement will take place. It may contain the BIC of a central settlement system eg CLSBUS33.
    /// </summary>
    [IsoId("_TIAQx9p-Ed-ak6NoX_4Aeg_1813124896")]
    [DisplayName("Settlement Party")]
    [IsoXmlTag("SttlmPty")]
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    
    
    #nullable disable
    
}
