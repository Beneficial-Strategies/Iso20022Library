// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code that identifies the type of MOTO transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3MsO4DHLEeyTT91yHXSlSQ")]
[Description(@"A code that identifies the type of MOTO transaction.")]
[DerivedFrom(typeof(MOTOCode))]
public enum MOTO1Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAOR&quot;.
    /// </summary>
    [EnumMember(Value = "MAOR")]
    [IsoId("_V2gisTxSEeyuG4d2lhAp-w")]
    [Description(@"Mail order.")]
    MailOrder = MOTOCode.MailOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as &quot;MOTO&quot;.
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_V6r4ETxSEeyuG4d2lhAp-w")]
    [Description(@"Mail order or telephone order.|")]
    MailOrderOrTelephoneOrder = MOTOCode.MailOrderOrTelephoneOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone order
    /// Encoded/decoded by serializers as &quot;TPOR&quot;.
    /// </summary>
    [EnumMember(Value = "TPOR")]
    [IsoId("_V-eL4TxSEeyuG4d2lhAp-w")]
    [Description(@"Telephone order")]
    TelephoneOrder = MOTOCode.TelephoneOrder, // same ordinal as derivation source for type conversions
}
