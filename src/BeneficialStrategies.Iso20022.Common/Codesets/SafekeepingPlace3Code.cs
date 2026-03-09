// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place of safekeeping.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-oF59p-Ed-ak6NoX_4Aeg_-597967030")]
[Description(@"Specifies the type of place of safekeeping.")]
[DerivedFrom(typeof(SafekeepingPlaceCode))]
public enum SafekeepingPlace3Code
{
    /// <summary>
    /// Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities.
    /// Encoded/decoded by serializers as &quot;SHHE&quot;.
    /// </summary>
    [EnumMember(Value = "SHHE")]
    [IsoId("_Y-oF6Np-Ed-ak6NoX_4Aeg_-505614155")]
    [Description(@"Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities.")]
    SharesHeldElsewhere = SafekeepingPlaceCode.SharesHeldElsewhere, // same ordinal as derivation source for type conversions
    
}
