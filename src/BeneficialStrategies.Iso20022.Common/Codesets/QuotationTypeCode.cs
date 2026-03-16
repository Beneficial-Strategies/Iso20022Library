// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of quotation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kgo8wNK4EeihtcVwfFPNlg")]
[Description(@"Specifies the type of quotation.")]
[Derivations(typeof(QuotationType1Code))]
public enum QuotationTypeCode
{
    /// <summary>
    /// Quotation is expressed as percentage.
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_p8ndQNK4EeihtcVwfFPNlg")]
    [Description(@"Quotation is expressed as percentage.")]
    Percentage,

    /// <summary>
    /// Quotation expressed as a currency and amount.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_zKp6INK4EeihtcVwfFPNlg")]
    [Description(@"Quotation expressed as a currency and amount.")]
    ActualAmount,
}
