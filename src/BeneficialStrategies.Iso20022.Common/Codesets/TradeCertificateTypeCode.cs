// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of trade certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YmVhstp-Ed-ak6NoX_4Aeg_706311619")]
[Description(@"Specifies the type of trade certificate.")]
[Derivations(typeof(TradeCertificateType1Code),typeof(TradeCertificateType2Code))]
public enum TradeCertificateTypeCode
{
    /// <summary>
    /// Certificate of analysis.
    /// Encoded/decoded by serializers as &quot;ANLY&quot;.
    /// </summary>
    [EnumMember(Value = "ANLY")]
    [IsoId("_YmVhs9p-Ed-ak6NoX_4Aeg_563823531")]
    [Description(@"Certificate of analysis.")]
    Analysis,
    
    /// <summary>
    /// Certificate of quality.
    /// Encoded/decoded by serializers as &quot;QUAL&quot;.
    /// </summary>
    [EnumMember(Value = "QUAL")]
    [IsoId("_YmVhtNp-Ed-ak6NoX_4Aeg_563823549")]
    [Description(@"Certificate of quality.")]
    Quality,
    
    /// <summary>
    /// Certificate of quantity.
    /// Encoded/decoded by serializers as &quot;QUAN&quot;.
    /// </summary>
    [EnumMember(Value = "QUAN")]
    [IsoId("_YmVhtdp-Ed-ak6NoX_4Aeg_563823550")]
    [Description(@"Certificate of quantity.")]
    Quantity,
    
    /// <summary>
    /// Certificate of weight.
    /// Encoded/decoded by serializers as &quot;WEIG&quot;.
    /// </summary>
    [EnumMember(Value = "WEIG")]
    [IsoId("_YmVhttp-Ed-ak6NoX_4Aeg_563823574")]
    [Description(@"Certificate of weight.")]
    Weight,
    
    /// <summary>
    /// Certificate of origin.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_YmVht9p-Ed-ak6NoX_4Aeg_563823575")]
    [Description(@"Certificate of origin.")]
    Origin,
    
    /// <summary>
    /// Certificate of health.
    /// Encoded/decoded by serializers as &quot;HEAL&quot;.
    /// </summary>
    [EnumMember(Value = "HEAL")]
    [IsoId("_YmVhuNp-Ed-ak6NoX_4Aeg_563823591")]
    [Description(@"Certificate of health.")]
    Health,
    
    /// <summary>
    /// Phytosanitary certificate.
    /// Encoded/decoded by serializers as &quot;PHYT&quot;.
    /// </summary>
    [EnumMember(Value = "PHYT")]
    [IsoId("_YmVhudp-Ed-ak6NoX_4Aeg_563823592")]
    [Description(@"Phytosanitary certificate.")]
    Phytosanitary,
    
    /// <summary>
    /// Beneficiary certificate.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_YmeroNp-Ed-ak6NoX_4Aeg_1629420522")]
    [Description(@"Beneficiary certificate.")]
    Beneficiary,
    
    /// <summary>
    /// Shipping line certificate.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_Ymerodp-Ed-ak6NoX_4Aeg_1656201715")]
    [Description(@"Shipping line certificate.")]
    ShippingLine,
    
    /// <summary>
    /// Undefined certificate at this stage.
    /// Encoded/decoded by serializers as &quot;UND1&quot;.
    /// </summary>
    [EnumMember(Value = "UND1")]
    [IsoId("_Ymerotp-Ed-ak6NoX_4Aeg_1675594307")]
    [Description(@"Undefined certificate at this stage.")]
    Undefined1,
    
    /// <summary>
    /// Undefined certificate at this stage.
    /// Encoded/decoded by serializers as &quot;UND2&quot;.
    /// </summary>
    [EnumMember(Value = "UND2")]
    [IsoId("_Ymero9p-Ed-ak6NoX_4Aeg_1953575415")]
    [Description(@"Undefined certificate at this stage.")]
    Undefined2,
    
}
