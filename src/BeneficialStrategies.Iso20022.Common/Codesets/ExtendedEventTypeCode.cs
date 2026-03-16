// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mchFTL3EeKU9IrkkToqcw_1589826234")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type."
)]
[Derivations(typeof(ExtendedEventType1Code))]
public enum ExtendedEventTypeCode
{
    /// <summary>
    /// Meeting of a company&apos;s share or bond holders to address resolutions put forth by the issuer. Note: this is information only event. Pending deprecation and migration to ISO Proxy Message suite.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_1mlrADL3EeKU9IrkkToqcw_588269517")]
    [Description(
        @"Meeting of a company's share or bond holders to address resolutions put forth by the issuer. Note: this is information only event. Pending deprecation and migration to ISO Proxy Message suite."
    )]
    Meeting,

    /// <summary>
    /// General information provided by the issuer that should not result in material changes to the security.
    /// Encoded/decoded by serializers as &quot;RPLA&quot;.
    /// </summary>
    [EnumMember(Value = "RPLA")]
    [IsoId("_1mlrATL3EeKU9IrkkToqcw_607228373")]
    [Description(
        @"General information provided by the issuer that should not result in material changes to the security."
    )]
    RightsPlanAdoption,

    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_1mlrAjL3EeKU9IrkkToqcw_1138262364")]
    [Description(
        @"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code."
    )]
    Termination,

    /// <summary>
    /// Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;BRIS&quot;.
    /// </summary>
    [EnumMember(Value = "BRIS")]
    [IsoId("_1mlrAzL3EeKU9IrkkToqcw_2131083886")]
    [Description(
        @"Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code."
    )]
    BonusRightsIssue,

    /// <summary>
    /// Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from &quot;partial defeasance&quot;, &quot;partial prerefunding&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;FLPR&quot;.
    /// </summary>
    [EnumMember(Value = "FLPR")]
    [IsoId("_1mlrBDL3EeKU9IrkkToqcw_1470985921")]
    [Description(
        @"Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from ""partial defeasance"", ""partial prerefunding"" event types mapped to the same ISO event type code."
    )]
    FullPrerefunding,

    /// <summary>
    /// Issuer sets aside cash in escrow to pay off a portion of the issue before the maturity date. New securities are issued for the portion defeased. Distinguishes from &quot;full prerefunding&quot;, &quot;partial prerefunding&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_1mlrBTL3EeKU9IrkkToqcw_256596043")]
    [Description(
        @"Issuer sets aside cash in escrow to pay off a portion of the issue before the maturity date. New securities are issued for the portion defeased. Distinguishes from ""full prerefunding"", ""partial prerefunding"" event types mapped to the same ISO event type code."
    )]
    PartialDefeasance,

    /// <summary>
    /// Similar to a Full Prerefunding, a partial prerefunding is the exercise of a privilege by the issuer to repay, in part, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. New securities are issued for the portion prerefunded. Distinguishes from &quot;full prerefunding&quot;, &quot;partial defeasance&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_1mlrBjL3EeKU9IrkkToqcw_-135348525")]
    [Description(
        @"Similar to a Full Prerefunding, a partial prerefunding is the exercise of a privilege by the issuer to repay, in part, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. New securities are issued for the portion prerefunded. Distinguishes from ""full prerefunding"", ""partial defeasance"" event types mapped to the same ISO event type code."
    )]
    PartialPrerefunding,
}
