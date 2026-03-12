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
[IsoId("_QZ0MOdp-Ed-ak6NoX_4Aeg_497605547")]
[DisplayName("Sub Balance Information")]
public partial record SubBalanceInformation3
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QZ0MOtp-Ed-ak6NoX_4Aeg_-541303772")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Type of subbalance.
    /// </summary>
    [IsoId("_QZ0MO9p-Ed-ak6NoX_4Aeg_2075045011")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType2Choice_ SubBalanceType { get; init; } 
    
    
    #nullable disable
    
}
