// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the storage location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WmlrkJx_EeuwYeL1lHu9zw")]
[Description(@"Code that specifies the storage location.")]
[DerivedFrom(typeof(StorageLocationCode))]
public enum StorageLocation1Code
{
    /// <summary>
    /// Storage is in wallet managed by card acceptor.
    /// Encoded/decoded by serializers as &quot;CAWL&quot;.
    /// </summary>
    [EnumMember(Value = "CAWL")]
    [IsoId("_d9jSEZx_EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by card acceptor.")]
    CardAcceptorWallet = StorageLocationCode.CardAcceptorWallet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stored in device.
    /// Encoded/decoded by serializers as &quot;DVCE&quot;.
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_eGbhQZx_EeuwYeL1lHu9zw")]
    [Description(@"Stored in device.")]
    Device = StorageLocationCode.Device, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage is in wallet managed by Issuer.
    /// Encoded/decoded by serializers as &quot;ISWL&quot;.
    /// </summary>
    [EnumMember(Value = "ISWL")]
    [IsoId("_euCT0Zx_EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by Issuer.")]
    IssuerWallet = StorageLocationCode.IssuerWallet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage is on file.
    /// Encoded/decoded by serializers as &quot;ONFL&quot;.
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_eu5PcZx_EeuwYeL1lHu9zw")]
    [Description(@"Storage is on file.")]
    OnFile = StorageLocationCode.OnFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code defined by national standards organisation.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_e5A0wZx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by national standards organisation.")]
    OtherNational = StorageLocationCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code defined by private agreement.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_fhei8Zx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by private agreement.")]
    OtherPrivate = StorageLocationCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage location is in wallet managed by a third party.
    /// Encoded/decoded by serializers as &quot;TPWL&quot;.
    /// </summary>
    [EnumMember(Value = "TPWL")]
    [IsoId("_fiTpYZx_EeuwYeL1lHu9zw")]
    [Description(@"Storage location is in wallet managed by a third party.")]
    ThirdPartyWallet = StorageLocationCode.ThirdPartyWallet, // same ordinal as derivation source for type conversions
}
