// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_15EiJjL3EeKU9IrkkToqcw_-1452988738")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[DerivedFrom(typeof(ExtendedEventTypeCode))]
public enum ExtendedEventType1Code
{
    /// <summary>
    /// General information provided by the issuer that should not result in material changes to the security.
    /// Encoded/decoded by serializers as &quot;RPLA&quot;.
    /// </summary>
    [EnumMember(Value = "RPLA")]
    [IsoId("_15OTIDL3EeKU9IrkkToqcw_-797256594")]
    [Description(@"General information provided by the issuer that should not result in material changes to the security.")]
    RightsPlanAdoption = ExtendedEventTypeCode.RightsPlanAdoption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_15OTITL3EeKU9IrkkToqcw_540063962")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.")]
    Termination = ExtendedEventTypeCode.Termination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;BRIS&quot;.
    /// </summary>
    [EnumMember(Value = "BRIS")]
    [IsoId("_15OTIjL3EeKU9IrkkToqcw_-343169325")]
    [Description(@"Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.")]
    BonusRightsIssue = ExtendedEventTypeCode.BonusRightsIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from &quot;partial defeasance&quot;, &quot;partial prerefunding&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;FLPR&quot;.
    /// </summary>
    [EnumMember(Value = "FLPR")]
    [IsoId("_15OTIzL3EeKU9IrkkToqcw_865181469")]
    [Description(@"Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from ""partial defeasance"", ""partial prerefunding"" event types mapped to the same ISO event type code.")]
    FullPrerefunding = ExtendedEventTypeCode.FullPrerefunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer sets aside cash in escrow to pay off a portion of the issue before the maturity date. New securities are issued for the portion defeased. Distinguishes from &quot;full prerefunding&quot;, &quot;partial prerefunding&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_15OTJDL3EeKU9IrkkToqcw_-18051818")]
    [Description(@"Issuer sets aside cash in escrow to pay off a portion of the issue before the maturity date. New securities are issued for the portion defeased. Distinguishes from ""full prerefunding"", ""partial prerefunding"" event types mapped to the same ISO event type code.")]
    PartialDefeasance = ExtendedEventTypeCode.PartialDefeasance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Similar to a Full Prerefunding, a partial prerefunding is the exercise of a privilege by the issuer to repay, in part, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. New securities are issued for the portion prerefunded. Distinguishes from &quot;full prerefunding&quot;, &quot;partial defeasance&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_15OTJTL3EeKU9IrkkToqcw_-1754719686")]
    [Description(@"Similar to a Full Prerefunding, a partial prerefunding is the exercise of a privilege by the issuer to repay, in part, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. New securities are issued for the portion prerefunded. Distinguishes from ""full prerefunding"", ""partial defeasance"" event types mapped to the same ISO event type code.")]
    PartialPrerefunding = ExtendedEventTypeCode.PartialPrerefunding, // same ordinal as derivation source for type conversions
    
}
