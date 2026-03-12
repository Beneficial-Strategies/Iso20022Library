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
[IsoId("_QY60W9p-Ed-ak6NoX_4Aeg_-2085094481")]
[DisplayName("Additional Balance Information")]
public partial record AdditionalBalanceInformation2
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QZElUNp-Ed-ak6NoX_4Aeg_-2085094479")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_QZElUdp-Ed-ak6NoX_4Aeg_-2085094464")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SecuritiesBalanceType2Code SubBalanceType { get; init; } 
    
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_QZElUtp-Ed-ak6NoX_4Aeg_2062170744")]
    [DisplayName("Extended Sub Balance Type")]
    [IsoXmlTag("XtndedSubBalTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedSubBalanceType { get; init; } 
    
    
    #nullable disable
    
}
