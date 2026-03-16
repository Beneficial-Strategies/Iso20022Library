// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the storage location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b6ylkJx-EeuwYeL1lHu9zw")]
[Description(@"Code that specifies the storage location.")]
[Derivations(typeof(StorageLocation1Code))]
public enum StorageLocationCode
{
    /// <summary>
    /// Stored in device.
    /// Encoded/decoded by serializers as &quot;DVCE&quot;.
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_k3ZUMJx-EeuwYeL1lHu9zw")]
    [Description(@"Stored in device.")]
    Device,

    /// <summary>
    /// Storage is on file.
    /// Encoded/decoded by serializers as &quot;ONFL&quot;.
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_qxgiMJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage is on file.")]
    OnFile,

    /// <summary>
    /// Storage is in wallet managed by card acceptor.
    /// Encoded/decoded by serializers as &quot;CAWL&quot;.
    /// </summary>
    [EnumMember(Value = "CAWL")]
    [IsoId("_xy5hUJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by card acceptor.")]
    CardAcceptorWallet,

    /// <summary>
    /// Storage is in wallet managed by Issuer.
    /// Encoded/decoded by serializers as &quot;ISWL&quot;.
    /// </summary>
    [EnumMember(Value = "ISWL")]
    [IsoId("_4I2WwJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by Issuer.")]
    IssuerWallet,

    /// <summary>
    /// Storage location is in wallet managed by a third party.
    /// Encoded/decoded by serializers as &quot;TPWL&quot;.
    /// </summary>
    [EnumMember(Value = "TPWL")]
    [IsoId("_-YK_wJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage location is in wallet managed by a third party.")]
    ThirdPartyWallet,

    /// <summary>
    /// Code defined by private agreement.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_D7VGUJx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by private agreement.")]
    OtherPrivate,

    /// <summary>
    /// Code defined by national standards organisation.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_H9R40Jx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by national standards organisation.")]
    OtherNational,
}
