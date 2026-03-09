// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the dividend.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axNd2dp-Ed-ak6NoX_4Aeg_-1189024253")]
[Description(@"Specifies the nature of the dividend.")]
public enum DividendTypeCode
{
    /// <summary>
    /// Dividend is paid in cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_axXO0Np-Ed-ak6NoX_4Aeg_-789142502")]
    [Description(@"Dividend is paid in cash.")]
    Cash,
    
    /// <summary>
    /// Dividend is paid in units.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_axXO0dp-Ed-ak6NoX_4Aeg_-789142485")]
    [Description(@"Dividend is paid in units.")]
    Units,
    
    /// <summary>
    /// Dividend is paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;SCRI&quot;.
    /// </summary>
    [EnumMember(Value = "SCRI")]
    [IsoId("_axXO0tp-Ed-ak6NoX_4Aeg_-773440098")]
    [Description(@"Dividend is paid in the form of scrip.")]
    Scrip,
    
    /// <summary>
    /// Dividend is paid in kind.
    /// Encoded/decoded by serializers as &quot;KIND&quot;.
    /// </summary>
    [EnumMember(Value = "KIND")]
    [IsoId("_axXO09p-Ed-ak6NoX_4Aeg_-358781618")]
    [Description(@"Dividend is paid in kind.")]
    InKind,
    
}
