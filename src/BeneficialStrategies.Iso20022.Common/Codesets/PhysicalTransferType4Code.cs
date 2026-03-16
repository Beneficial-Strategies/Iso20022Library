// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the asset delivery type when the financial instrument is settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nzrsQIBAEeall68-KLgmUw")]
[Description(@"Specifies the asset delivery type when the financial instrument is settled.")]
[DerivedFrom(typeof(PhysicalTransferTypeV2Code))]
public enum PhysicalTransferType4Code
{
    /// <summary>
    /// Physical transfer.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_tMiAQYBAEeall68-KLgmUw")]
    [Description(@"Physical transfer.")]
    Physical = PhysicalTransferTypeV2Code.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Determined by a third party or optional for counterparty.
    /// Encoded/decoded by serializers as &quot;OPTL&quot;.
    /// </summary>
    [EnumMember(Value = "OPTL")]
    [IsoId("_tbaJwYBAEeall68-KLgmUw")]
    [Description(@"Determined by a third party or optional for counterparty.")]
    Optional = PhysicalTransferTypeV2Code.Optional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash transfer.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_tmRV8YBAEeall68-KLgmUw")]
    [Description(@"Cash transfer.")]
    Cash = PhysicalTransferTypeV2Code.Cash, // same ordinal as derivation source for type conversions
}
