// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a mandate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afxvk9p-Ed-ak6NoX_4Aeg_1808299686")]
[Description(@"Specifies the reason for requesting the cancellation of a mandate.")]
[DerivedFrom(typeof(MandateReasonCode))]
public enum MandateCancellationReason1Code
{
    /// <summary>
    /// Agent details are incorrect or have changed.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_afxvlNp-Ed-ak6NoX_4Aeg_1808299688")]
    [Description(@"Agent details are incorrect or have changed.")]
    IncorrectAgent = MandateReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency for the mandate is incorrect or has changed.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_afxvldp-Ed-ak6NoX_4Aeg_1808299933")]
    [Description(@"Currency for the mandate is incorrect or has changed.")]
    IncorrectCurrency = MandateReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer requested the change.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_afxvltp-Ed-ak6NoX_4Aeg_1808299934")]
    [Description(@"Customer requested the change.")]
    RequestedByCustomer = MandateReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or incoherent details about the debtor.
    /// Encoded/decoded by serializers as &quot;DBTR&quot;.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_afxvl9p-Ed-ak6NoX_4Aeg_1808299964")]
    [Description(@"Insufficient or incoherent details about the debtor.")]
    InsufficientDebtorDetails = MandateReasonCode.InsufficientDebtorDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or incoherent details about the creditor.
    /// Encoded/decoded by serializers as &quot;CDTR&quot;.
    /// </summary>
    [EnumMember(Value = "CDTR")]
    [IsoId("_afxvmNp-Ed-ak6NoX_4Aeg_1808299965")]
    [Description(@"Insufficient or incoherent details about the creditor.")]
    InsufficientCreditorDetails = MandateReasonCode.InsufficientCreditorDetails, // same ordinal as derivation source for type conversions
}
