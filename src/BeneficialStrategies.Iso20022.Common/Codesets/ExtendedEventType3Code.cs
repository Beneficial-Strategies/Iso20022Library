// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JpJNUJ5REeWsgrkrngh7Ew")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
public enum ExtendedEventType3Code
{
    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_VygL0Z5REeWsgrkrngh7Ew")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.")]
    Termination = ExtendedEventTypeV2Code.Termination, // same ordinal as derivation source for type conversions
    
}
