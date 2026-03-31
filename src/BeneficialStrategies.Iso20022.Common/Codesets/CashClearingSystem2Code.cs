// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of payment system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a4g_sdp-Ed-ak6NoX_4Aeg_-736776855")]
[Description(@"Specifies a type of payment system.")]
[DerivedFrom(typeof(CashClearingSystemCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashClearingSystem2Code>))]
#endif
public enum CashClearingSystem2Code
{
    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as &quot;RTG&quot;.
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_a4g_stp-Ed-ak6NoX_4Aeg_-351665378")]
    [Description(
        @"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money."
    )]
    RTGS = CashClearingSystemCode.RTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;ACH&quot;.
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_a4g_s9p-Ed-ak6NoX_4Aeg_-288868274")]
    [Description(
        @"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis."
    )]
    ACH = CashClearingSystemCode.ACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CHIPS is the Clearing House Interbank Payment System in the US.
    /// Encoded/decoded by serializers as &quot;CHI&quot;.
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_a4g_tNp-Ed-ak6NoX_4Aeg_-400546927")]
    [Description(@"CHIPS is the Clearing House Interbank Payment System in the US.")]
    USChips = CashClearingSystemCode.USChips, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FedNet is a link to a Federal Bank account via the internet. FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc.
    /// Encoded/decoded by serializers as &quot;FDN&quot;.
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_a4g_tdp-Ed-ak6NoX_4Aeg_-284181622")]
    [Description(
        @"FedNet is a link to a Federal Bank account via the internet. FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc."
    )]
    FedNet = CashClearingSystemCode.FedNet, // same ordinal as derivation source for type conversions
}
