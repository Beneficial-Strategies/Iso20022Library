// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding optional dividend election details.
/// </summary>
[IsoId("_1a-Q4jL3EeKU9IrkkToqcw_2124863558")]
[DisplayName("Optional Dividend Account Quantity SD")]
public partial record OptionalDividendAccountQuantitySD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1a-Q4zL3EeKU9IrkkToqcw_1063188442")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_1a-Q5DL3EeKU9IrkkToqcw_1896947703")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Beneficial owner quantity to be paid.
    /// </summary>
    [IsoId("_1a-Q5TL3EeKU9IrkkToqcw_1485169123")]
    [DisplayName("Beneficial Owner Quantity")]
    [IsoXmlTag("BnfclOwnrQty")]
    public required FinancialInstrumentQuantity15Choice_ BeneficialOwnerQuantity { get; init; } 
    
    
    #nullable disable
    
}
