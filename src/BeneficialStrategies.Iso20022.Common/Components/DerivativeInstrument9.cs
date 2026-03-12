// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the derivative instrument.
/// </summary>
[IsoId("_1V6QYZ3DEeuwmdq0KtnICg")]
[DisplayName("Derivative Instrument")]
public partial record DerivativeInstrument9
{
    #nullable enable
    
    /// <summary>
    /// Original expiry date of the reported financial instrument. 
    /// Usage:
    /// Field applies to derivatives with defined expiry date.
    /// </summary>
    [IsoId("_1tAhwZ3DEeuwmdq0KtnICg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// For a future or option on an index, the amount per index point.
    /// </summary>
    [IsoId("_1tAhw53DEeuwmdq0KtnICg")]
    [DisplayName("Price Multiplier")]
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.NonNegativeDecimalNumber)]
    public required IsoNonNegativeDecimalNumber PriceMultiplier { get; init; } 
    
    /// <summary>
    /// Choice to specify the type(s) of underlying instrument(s) that make up the financial instrument.
    /// </summary>
    [IsoId("_1tAhx53DEeuwmdq0KtnICg")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public required UnderlyingIdentification3Choice_ UnderlyingInstrument { get; init; } 
    
    /// <summary>
    /// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_1tAhyZ3DEeuwmdq0KtnICg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Code? OptionType { get; init; } 
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_1tAhy53DEeuwmdq0KtnICg")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public SecuritiesTransactionPrice4Choice_? StrikePrice { get; init; } 
    
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    [IsoId("_1tAhz53DEeuwmdq0KtnICg")]
    [DisplayName("Option Exercise Style")]
    [IsoXmlTag("OptnExrcStyle")]
    public OptionStyle7Code? OptionExerciseStyle { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction is settled physically or in cash.
    /// </summary>
    [IsoId("_1tAh0Z3DEeuwmdq0KtnICg")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public required PhysicalTransferType4Code DeliveryType { get; init; } 
    
    /// <summary>
    /// Specific attributes of the underlying asset class of the financial instrument.
    /// </summary>
    [IsoId("_1tAh053DEeuwmdq0KtnICg")]
    [DisplayName("Asset Class Specific Attributes")]
    [IsoXmlTag("AsstClssSpcfcAttrbts")]
    public AssetClassAttributes1Choice_? AssetClassSpecificAttributes { get; init; } 
    
    
    #nullable disable
    
}
