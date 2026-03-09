// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of quotation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFUTgNK5EeihtcVwfFPNlg")]
[Description(@"Specifies the type of quotation.")]
[DerivedFrom(typeof(QuotationTypeCode))]
public enum QuotationType1Code
{
    /// <summary>
    /// Quotation expressed as a currency and amount.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_anpo8dK5EeihtcVwfFPNlg")]
    [Description(@"Quotation expressed as a currency and amount.")]
    ActualAmount = QuotationTypeCode.ActualAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quotation is expressed as percentage.
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_atwQ8dK5EeihtcVwfFPNlg")]
    [Description(@"Quotation is expressed as percentage.")]
    Percentage = QuotationTypeCode.Percentage, // same ordinal as derivation source for type conversions
    
}
