// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UIVnYHaaEeavseMKyTsJEA")]
[Description(@"Identification of the type of the transaction.")]
[DerivedFrom(typeof(ExposureTypeCode))]
public enum ExposureType6Code
{
    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_cpr9YXaaEeavseMKyTsJEA")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeCode.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin lending transaction.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_eIA8kXaaEeavseMKyTsJEA")]
    [Description(@"Margin lending transaction. ")]
    MarginLending = ExposureTypeCode.MarginLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_fyWXcXaaEeavseMKyTsJEA")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeCode.RepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_kB3r4XaaEeavseMKyTsJEA")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeCode.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions
}
