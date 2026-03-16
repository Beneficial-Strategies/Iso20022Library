// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information on Funding sources used to finance margin loans.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9_E2EFXIEeeUQbJN-rt4dg")]
[Description(@"Information on Funding sources used to finance margin loans.")]
[Derivations(typeof(FundingSourceType1Code))]
public enum FundingSourcesTypeCode
{
    /// <summary>
    /// Type of a funding source is repo or buy sell back.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_kDhdkFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is repo or buy sell back.")]
    RepoOrBSB,

    /// <summary>
    /// Type of a funding source is cash collateral from securities lending.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_mnICwFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is cash collateral from securities lending. ")]
    CashCollateralFromSecuritiesLending,

    /// <summary>
    /// Type of a funding source is free credits.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_q0pzIFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is free credits. ")]
    FreeCredits,

    /// <summary>
    /// Type of a funding source is proceeds from customer short sales.
    /// Encoded/decoded by serializers as &quot;CSHS&quot;.
    /// </summary>
    [EnumMember(Value = "CSHS")]
    [IsoId("_s9P3UFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from customer short sales. ")]
    ProceedsFromCustomerShortSales,

    /// <summary>
    /// Type of a funding source is proceeds from broker short sales.
    /// Encoded/decoded by serializers as &quot;BSHS&quot;.
    /// </summary>
    [EnumMember(Value = "BSHS")]
    [IsoId("_vKS9sFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from broker short sales. ")]
    ProceedsFromBrokerShortSales,

    /// <summary>
    /// Type of a funding source is unsecured borrowing.
    /// Encoded/decoded by serializers as &quot;UBOR&quot;.
    /// </summary>
    [EnumMember(Value = "UBOR")]
    [IsoId("_xedYsFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is unsecured borrowing. ")]
    UnsecuredBorrowing,

    /// <summary>
    /// Other type of a funding source.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_zwYYAFXJEeeUQbJN-rt4dg")]
    [Description(@"Other type of a funding source.")]
    Other,
}
