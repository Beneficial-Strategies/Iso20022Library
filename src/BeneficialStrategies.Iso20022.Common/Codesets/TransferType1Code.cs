// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the financial instrument is transferred as an asset or as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YvbMR9p-Ed-ak6NoX_4Aeg_-1593227544")]
[Description(@"Specifies whether the financial instrument is transferred as an asset or as cash.")]
[DerivedFrom(typeof(TransferTypeCode))]
public enum TransferType1Code
{
    /// <summary>
    /// Transfer the security as an asset in specie, that is, &apos;in its actual form&apos;.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YvbMSNp-Ed-ak6NoX_4Aeg_-1303244696")]
    [Description(@"Transfer the security as an asset in specie, that is, 'in its actual form'.")]
    InSpecie = TransferTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer as cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Yvk9QNp-Ed-ak6NoX_4Aeg_-1291238985")]
    [Description(@"Transfer as cash.")]
    Cash = TransferTypeCode.Cash, // same ordinal as derivation source for type conversions
    
}
