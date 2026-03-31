// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Mode of data encoding supported by exchanges.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CAPEEncodingMode1Code")]
[Description(@"Mode of data encoding supported by exchanges.")]
[DerivedFrom(typeof(CAPEEncodingModeCode))]
public enum CAPEEncodingMode1Code
{
    /// <summary>
    /// Data exchanged with the protocol between both parties are encoded in JSON.
    /// Encoded/decoded by serializers as &quot;JSON&quot;.
    /// </summary>
    [EnumMember(Value = "JSON")]
    [IsoId("_CAPEEncodingMode1Code_JSONEncoding")]
    [Description(@"Data exchanged with the protocol between both parties are encoded in JSON.")]
    JSONEncoding = CAPEEncodingModeCode.JSONEncoding,

    /// <summary>
    /// Data exchanged with the protocol between both parties are encoded in XML.
    /// Encoded/decoded by serializers as &quot;XMLE&quot;.
    /// </summary>
    [EnumMember(Value = "XMLE")]
    [IsoId("_CAPEEncodingMode1Code_XMLEncoding")]
    [Description(@"Data exchanged with the protocol between both parties are encoded in XML.")]
    XMLEncoding = CAPEEncodingModeCode.XMLEncoding,
}
