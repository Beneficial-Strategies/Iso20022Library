// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial instrument is transferred as an asset or as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v38AIMVaEei2doMlOscgeg")]
[Description(@"Specifies whether a financial instrument is transferred as an asset or as cash.")]
[DerivedFrom(typeof(TransferTypeCode))]
public enum TransferType3Code
{
    /// <summary>
    /// Transfer the security as an asset in specie, that is, &apos;in its actual form&apos;.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_y8BcMcVaEei2doMlOscgeg")]
    [Description(@"Transfer the security as an asset in specie, that is, 'in its actual form'.")]
    InSpecie = TransferTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer as cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_zB1JQcVaEei2doMlOscgeg")]
    [Description(@"Transfer as cash.")]
    Cash = TransferTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ISIN is converted to another ISIN and then transferred.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_zHfFUcVaEei2doMlOscgeg")]
    [Description(@"ISIN is converted to another ISIN and then transferred.")]
    Conversion = TransferTypeCode.Conversion, // same ordinal as derivation source for type conversions
    
}
