// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aksr0dp-Ed-ak6NoX_4Aeg_-483323603")]
[Description(@"Identifies the type of event.")]
[Derivations(typeof(EventType1Code))]
public enum EventTypeCode
{
    /// <summary>
    /// In fixed income this is the put provision on the bond allowing the investor the right to &quot;redeem the bond at a specified price prior to maturity&quot;.
    /// Encoded/decoded by serializers as &quot;PUT1&quot;.
    /// </summary>
    [EnumMember(Value = "PUT1")]
    [IsoId("_aksr0tp-Ed-ak6NoX_4Aeg_-441766477")]
    [Description(
        @"In fixed income this is the put provision on the bond allowing the investor the right to ""redeem the bond at a specified price prior to maturity""."
    )]
    Put,

    /// <summary>
    /// In fixed income this is the call provision on the bond allowing the bond issuer &quot;the right to redeem [the bond] prior to its maturity date, under certain conditions.&quot;.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_aksr09p-Ed-ak6NoX_4Aeg_-184106239")]
    [Description(
        @"In fixed income this is the call provision on the bond allowing the bond issuer ""the right to redeem [the bond] prior to its maturity date, under certain conditions.""."
    )]
    Call,

    /// <summary>
    /// Synonymous with Put but is the preferred term for certain asset classes in some markets.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_aksr1Np-Ed-ak6NoX_4Aeg_-78821373")]
    [Description(
        @"Synonymous with Put but is the preferred term for certain asset classes in some markets."
    )]
    Tender,

    /// <summary>
    /// Date when the security is activated for trading and clearing.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_aksr1dp-Ed-ak6NoX_4Aeg_-50192669")]
    [Description(@"Date when the security is activated for trading and clearing.")]
    Activation,

    /// <summary>
    /// Date when the security is no longer available for trading and clearing.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_aksr1tp-Ed-ak6NoX_4Aeg_1224264265")]
    [Description(@"Date when the security is no longer available for trading and clearing.")]
    Inactivation,

    /// <summary>
    /// A provision allowing a bond issuer the opportunity to buy outstanding bonds from bondholders for a set rate, using money (a sinking fund) from the issuer&apos;s earnings saved specifically for security buybacks. Because it adds doubt for investors over whether the bond will continue to pay until its maturity date, a sinking fund call is seen as an additional risk for investors.
    /// Encoded/decoded by serializers as &quot;SFCA&quot;.
    /// </summary>
    [EnumMember(Value = "SFCA")]
    [IsoId("_aksr19p-Ed-ak6NoX_4Aeg_20211718")]
    [Description(
        @"A provision allowing a bond issuer the opportunity to buy outstanding bonds from bondholders for a set rate, using money (a sinking fund) from the issuer's earnings saved specifically for security buybacks. Because it adds doubt for investors over whether the bond will continue to pay until its maturity date, a sinking fund call is seen as an additional risk for investors."
    )]
    SinkingFundCall,
}
