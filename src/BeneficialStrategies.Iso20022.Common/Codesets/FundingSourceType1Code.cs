// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of a funding used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7yTnEFXJEeeUQbJN-rt4dg")]
[Description(@"Type of a funding used.")]
[DerivedFrom(typeof(FundingSourcesTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FundingSourceType1Code>))]
#endif
public enum FundingSourceType1Code
{
    /// <summary>
    /// Type of a funding source is cash collateral from securities lending.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_9FUuIVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is cash collateral from securities lending. ")]
    CashCollateralFromSecuritiesLending =
        FundingSourcesTypeCode.CashCollateralFromSecuritiesLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of a funding source is free credits.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_9KwnwVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is free credits. ")]
    FreeCredits = FundingSourcesTypeCode.FreeCredits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of a funding source.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9PbsYVXJEeeUQbJN-rt4dg")]
    [Description(@"Other type of a funding source.")]
    Other = FundingSourcesTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of a funding source is proceeds from broker short sales.
    /// Encoded/decoded by serializers as &quot;BSHS&quot;.
    /// </summary>
    [EnumMember(Value = "BSHS")]
    [IsoId("_9UZE4VXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from broker short sales. ")]
    ProceedsFromBrokerShortSales = FundingSourcesTypeCode.ProceedsFromBrokerShortSales, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of a funding source is proceeds from customer short sales.
    /// Encoded/decoded by serializers as &quot;CSHS&quot;.
    /// </summary>
    [EnumMember(Value = "CSHS")]
    [IsoId("_9Zu34VXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from customer short sales. ")]
    ProceedsFromCustomerShortSales = FundingSourcesTypeCode.ProceedsFromCustomerShortSales, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of a funding source is repo or buy sell back.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_9eBiAVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is repo or buy sell back.")]
    RepoOrBSB = FundingSourcesTypeCode.RepoOrBSB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of a funding source is unsecured borrowing.
    /// Encoded/decoded by serializers as &quot;UBOR&quot;.
    /// </summary>
    [EnumMember(Value = "UBOR")]
    [IsoId("_9j12IVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is unsecured borrowing. ")]
    UnsecuredBorrowing = FundingSourcesTypeCode.UnsecuredBorrowing, // same ordinal as derivation source for type conversions
}
