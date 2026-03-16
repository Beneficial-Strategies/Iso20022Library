// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial instrument is transferred as an asset or as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yvk9Qdp-Ed-ak6NoX_4Aeg_-1137009397")]
[Description(@"Specifies whether a financial instrument is transferred as an asset or as cash.")]
[Derivations(typeof(TransferType1Code), typeof(TransferType3Code), typeof(TransferType4Code))]
public enum TransferTypeCode
{
    /// <summary>
    /// Transfer the security as an asset in specie, that is, &apos;in its actual form&apos;.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Yvk9Qtp-Ed-ak6NoX_4Aeg_-1137009131")]
    [Description(@"Transfer the security as an asset in specie, that is, 'in its actual form'.")]
    InSpecie,

    /// <summary>
    /// Transfer as cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Yvk9Q9p-Ed-ak6NoX_4Aeg_-1137009106")]
    [Description(@"Transfer as cash.")]
    Cash,

    /// <summary>
    /// ISIN is converted to another ISIN and then transferred.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_uSFHgcVYEei2doMlOscgeg")]
    [Description(@"ISIN is converted to another ISIN and then transferred.")]
    Conversion,

    /// <summary>
    /// Asset excluded from transfer.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_qbM2EKxWEemRcYBAkJyjkg")]
    [Description(@"Asset excluded from transfer.")]
    Excluded,
}
