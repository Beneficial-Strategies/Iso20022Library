// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_QZqbMdp-Ed-ak6NoX_4Aeg_223622935")]
[DisplayName("Additional Balance Information")]
public partial record AdditionalBalanceInformation3
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QZqbMtp-Ed-ak6NoX_4Aeg_-1511610862")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_QZqbM9p-Ed-ak6NoX_4Aeg_-1026734239")]
    [DisplayName("Additional Balance Information")]
    [IsoXmlTag("AddtlBalInf")]
    public required SubBalanceType1Choice_ AdditionalBalanceInformation { get; init; } 
    
    
    #nullable disable
    
}
