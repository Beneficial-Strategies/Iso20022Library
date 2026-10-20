// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the storage location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXgOQS9cEfCD0_iZ8tw-zA")]
[Description(@"Code that specifies the storage location.")]
[DerivedFrom(typeof(StorageLocationCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<StorageLocation2Code>))]
public enum StorageLocation2Code
{
    /// <summary>
    /// Storage is in wallet managed by card acceptor.
    /// Encoded/decoded by serializers as &quot;CAWL&quot;.
    /// </summary>
    [EnumMember(Value = "CAWL")]
    [IsoId("_YZ_hkS9cEfCD0_iZ8tw-zA")]
    [Description(@"Storage is in wallet managed by card acceptor.")]
    CardAcceptorWallet = StorageLocationCode.CardAcceptorWallet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stored in device.
    /// Encoded/decoded by serializers as &quot;DVCE&quot;.
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_YZ_hky9cEfCD0_iZ8tw-zA")]
    [Description(@"Stored in device.")]
    Device = StorageLocationCode.Device, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage is in wallet managed by Issuer.
    /// Encoded/decoded by serializers as &quot;ISWL&quot;.
    /// </summary>
    [EnumMember(Value = "ISWL")]
    [IsoId("_YZ_hlS9cEfCD0_iZ8tw-zA")]
    [Description(@"Storage is in wallet managed by Issuer.")]
    IssuerWallet = StorageLocationCode.IssuerWallet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage is on file.
    /// Encoded/decoded by serializers as &quot;ONFL&quot;.
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_YZ_hly9cEfCD0_iZ8tw-zA")]
    [Description(@"Storage is on file.")]
    OnFile = StorageLocationCode.OnFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage location is in wallet managed by a third party.
    /// Encoded/decoded by serializers as &quot;TPWL&quot;.
    /// </summary>
    [EnumMember(Value = "TPWL")]
    [IsoId("_YZ_hnS9cEfCD0_iZ8tw-zA")]
    [Description(@"Storage location is in wallet managed by a third party.")]
    ThirdPartyWallet = StorageLocationCode.ThirdPartyWallet, // same ordinal as derivation source for type conversions
}
