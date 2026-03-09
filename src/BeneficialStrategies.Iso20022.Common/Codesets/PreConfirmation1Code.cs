// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if there is a pre-confirmation of cash or securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdTddg93EeGeV5vP7Mvdig_-976669402")]
[Description(@"Specifies if there is a pre-confirmation of cash or securities.")]
[DerivedFrom(typeof(PreConfirmationCode))]
public enum PreConfirmation1Code
{
    /// <summary>
    /// Pre-confirmation of the movement of the cash, pending the movement of securities.
    /// Encoded/decoded by serializers as &quot;PRCA&quot;.
    /// </summary>
    [EnumMember(Value = "PRCA")]
    [IsoId("_zdcnYA93EeGeV5vP7Mvdig_1988763861")]
    [Description(@"Pre-confirmation of the movement of the cash, pending the movement of securities.")]
    PreConfirmCash = PreConfirmationCode.PreConfirmCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pre-confirmation of the movement of the securities, pending the movement of cash.
    /// Encoded/decoded by serializers as &quot;PRSE&quot;.
    /// </summary>
    [EnumMember(Value = "PRSE")]
    [IsoId("_zdcnYQ93EeGeV5vP7Mvdig_-1228183097")]
    [Description(@"Pre-confirmation of the movement of the securities, pending the movement of cash.")]
    PreConfirmSecurities = PreConfirmationCode.PreConfirmSecurities, // same ordinal as derivation source for type conversions
    
}
