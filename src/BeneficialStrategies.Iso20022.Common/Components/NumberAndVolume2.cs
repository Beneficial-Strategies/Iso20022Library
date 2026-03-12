// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detail the number and the volume, defined by currency amount, for use in a transaction.
/// </summary>
[IsoId("_paGL8WlAEeaLAKoEUNsD9g")]
[DisplayName("Number And Volume")]
public partial record NumberAndVolume2
{
    #nullable enable
    
    /// <summary>
    /// Total number of specific transaction types executed on the reporting day.
    /// </summary>
    [IsoId("_pi_CMWlAEeaLAKoEUNsD9g")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumberFraction5)]
    public required IsoDecimalNumberFraction5 Number { get; init; } 
    
    /// <summary>
    /// Total volume of specific transactions executed on the reporting day.
    /// </summary>
    [IsoId("_pi_CM2lAEeaLAKoEUNsD9g")]
    [DisplayName("Volume")]
    [IsoXmlTag("Vol")]
    public required ActiveOrHistoricCurrencyAndAmount Volume { get; init; } 
    
    
    #nullable disable
    
}
