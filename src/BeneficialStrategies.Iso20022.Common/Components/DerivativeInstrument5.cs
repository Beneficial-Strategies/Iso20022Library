// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the derivative instrument.
/// </summary>
[IsoId("_G_iQo35aEea2k7EBUopqxw")]
[DisplayName("Derivative Instrument")]
public record DerivativeInstrument5
{
    /// <summary>
    /// Expiry date of the financial instrument.
    /// </summary>
    [IsoId("_HH3GI35aEea2k7EBUopqxw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract. For a future or option on an index, the amount per index point.
    /// </summary>
    [IsoId("_HH3GJX5aEea2k7EBUopqxw")]
    [DisplayName("Price Multiplier")]
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.NonNegativeDecimalNumber)]
    public IsoNonNegativeDecimalNumber? PriceMultiplier { get; init; }

    /// <summary>
    /// Choice to specify the type(s) of underlying instrument(s) that make up the financial instrument.
    /// </summary>
    [IsoId("_HH3GKX5aEea2k7EBUopqxw")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public FinancialInstrumentIdentification5Choice_? UnderlyingInstrument { get; init; }

    /// <summary>
    /// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// Usage:
    /// Within the scope of MiFIR, RTS 23, the following meanings should be used where a swaption is being detailed, “Put”, in case of receiver swaption, in which the buyer has the right to enter into a swap as a fixed-rate receiver. Call”, in case of payer swaption, in which the buyer has the right to enter into a swap as a fixed-rate payer. Caps and floors shall interpret this field as, &quot;Put”, in case of a Floor, &quot;Call”, in case of a Cap. Field only applies to derivatives that are options or warrants.
    /// </summary>
    [IsoId("_HH3GK35aEea2k7EBUopqxw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Code? OptionType { get; init; }

    /// <summary>
    /// Attributes to specify the strike price of a derivative.
    /// Usage:
    /// Within the scope of MiFIR RTS 23, these are the fields 31 and 32. This field only applies to options, warrants, spread bet on an option on an equity or contract for difference on an option on an equity. Where price is currently not available but pending, the value shall be ’PNDG’. Where strike price is not applicable it shall not be populated.
    /// </summary>
    [IsoId("_HH3GLX5aEea2k7EBUopqxw")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public SecuritiesTransactionPrice4Choice_? StrikePrice { get; init; }

    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style).
    /// Usage:
    /// Within the scope of MiFIR, RTS 23, this field is only applicable for options, warrants and entitlement certificates.
    /// </summary>
    [IsoId("_HH3GMX5aEea2k7EBUopqxw")]
    [DisplayName("Option Exercise Style")]
    [IsoXmlTag("OptnExrcStyle")]
    public OptionStyle7Code? OptionExerciseStyle { get; init; }

    /// <summary>
    /// Indicates whether the transaction is settled physically or in cash.
    /// </summary>
    [IsoId("_HH3GM35aEea2k7EBUopqxw")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public PhysicalTransferType4Code? DeliveryType { get; init; }

    /// <summary>
    /// Specific attributes of the underlying asset class of the financial instrument.
    /// </summary>
    [IsoId("_HH3GNX5aEea2k7EBUopqxw")]
    [DisplayName("Asset Class Specific Attributes")]
    [IsoXmlTag("AsstClssSpcfcAttrbts")]
    public AssetClass2? AssetClassSpecificAttributes { get; init; }
}
