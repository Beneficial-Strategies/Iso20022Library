// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of trade certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YmLwt9p-Ed-ak6NoX_4Aeg_1999753422")]
[Description(@"Specifies the type of trade certificate.")]
[DerivedFrom(typeof(TradeCertificateTypeCode))]
public enum TradeCertificateType2Code
{
    /// <summary>
    /// Beneficiary certificate.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_YmLwuNp-Ed-ak6NoX_4Aeg_2058856409")]
    [Description(@"Beneficiary certificate.")]
    Beneficiary = TradeCertificateTypeCode.Beneficiary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shipping line certificate.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_YmLwudp-Ed-ak6NoX_4Aeg_2058856410")]
    [Description(@"Shipping line certificate.")]
    ShippingLine = TradeCertificateTypeCode.ShippingLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undefined certificate at this stage.
    /// Encoded/decoded by serializers as &quot;UND1&quot;.
    /// </summary>
    [EnumMember(Value = "UND1")]
    [IsoId("_YmVhsNp-Ed-ak6NoX_4Aeg_2058856418")]
    [Description(@"Undefined certificate at this stage.")]
    Undefined1 = TradeCertificateTypeCode.Undefined1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undefined certificate at this stage.
    /// Encoded/decoded by serializers as &quot;UND2&quot;.
    /// </summary>
    [EnumMember(Value = "UND2")]
    [IsoId("_YmVhsdp-Ed-ak6NoX_4Aeg_2058856419")]
    [Description(@"Undefined certificate at this stage.")]
    Undefined2 = TradeCertificateTypeCode.Undefined2, // same ordinal as derivation source for type conversions
    
}
